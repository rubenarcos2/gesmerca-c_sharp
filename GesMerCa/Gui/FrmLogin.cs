/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Windows.Forms;
using GesMerCa.Objs;
using System.Collections.Generic;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing;
using GesMerCa.Utils;

namespace GesMerCa
{
    public partial class FrmLogin : Form
    {
        #region Atributos

        System.ComponentModel.ComponentResourceManager recursosApp;

        private Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso;

        #region Login Uss/Pass
        private const int MAX_NUM_INTENTOS = 3;
        private int numIntentos;
        private bool bloqueadoAcceso;
        private bool mantenerUsuario;
        #endregion

        #region Login Facial
        Image<Bgr, Byte> fotogramaActual;
        Capture camaraCapturadora;
        HaarCascade patronCara;
        MCvFont tipoLetra = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> resultado, imagenUssRegistrado = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> imagenesUssRegistrados = new List<Image<Gray, byte>>();
        List<string> listaNombres = new List<string>();
        string usuarioReconocido = null;
        private int idUsuario;
        private int numReconocimientos = 0;
        private int numReconDesconocido = 0;
        private int ajustePrecisionRec = 2500; //Entre 3000-2000
        private Utils.Const.LOGINFACIAL_MODO_ACCESO modoLoginFacial;
        #endregion

        #endregion

        #region Constructores

        public FrmLogin(Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso)
        {
            //Carga el fichero de recursos con las cadenas de los idiomas
            recursosApp = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            InitializeComponent();
            switch (modoAcceso)
            {
                case Utils.Const.LOGIN_MODO_IDENTIFICACION.USS_PASS:
                    numIntentos = 0;
                    bloqueadoAcceso = false;
                    break;
                case Utils.Const.LOGIN_MODO_IDENTIFICACION.FACIAL:
                    imgLogin.Visible = false;
                    grpUssPass.Visible = false;
                    imageBoxFrameGrabber.Visible = true;
                    inicializarDeteccionFacial();
                    break;
                case Utils.Const.LOGIN_MODO_IDENTIFICACION.TARJETA:
                    numIntentos = 0;
                    bloqueadoAcceso = false;
                    lblPass.Visible = false;
                    txtPassword.Visible = false;
                    lblUss.Text = Properties.Resources.msgLoginCodigo;
                    imgLogin.Image = Properties.Resources.codebar;
                    imgLogin.SizeMode = PictureBoxSizeMode.Zoom;
                    this.ActiveControl = txtNombre;
                    break;
            }
            this.modoAcceso = modoAcceso;
            mantenerUsuario = false;
        }

        public FrmLogin(Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso, Utils.Const.LOGINFACIAL_MODO_ACCESO modoLoginFacial) : this(modoAcceso)
        {
            this.modoLoginFacial = modoLoginFacial;
        }

        public FrmLogin(Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso, Utils.Const.LOGINFACIAL_MODO_ACCESO modoLoginFacial, int idUsuario) : this(modoAcceso, modoLoginFacial)
        {
            this.idUsuario = idUsuario;
            btnAceptar.Text = Properties.Resources.btnLoginGuardarImagen;
            btnAceptar.Visible = true;
        }

        public FrmLogin(Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso, string usuario) : this(modoAcceso)
        {
            txtNombre.Text = usuario;
            txtNombre.Enabled = false;
            mantenerUsuario = true;
        }

        #endregion

        #region Eventos botones

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string password = txtPassword.Text;

            if (modoLoginFacial == Utils.Const.LOGINFACIAL_MODO_ACCESO.Entrenamiento)
            {
                guardarImagenUsuarioEntrenamiento();
                DialogResult dialogo = MessageBox.Show(Properties.Resources.msgLoginAlmacenarImagenCamara, Properties.Resources.msgLoginAlmacenarImagenCamaraTitulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogo != DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            //Modo acceso LOGIN USS/PASS o modo acceso LOGIN FACIAL - RECONOCIMIENTO
            else
            {
                if (String.IsNullOrEmpty(nombre))
                {
                    controlErrores.Dispose();
                    controlErrores.SetError(txtNombre, Properties.Resources.msgControlErroresUsuario);
                }
                else if (String.IsNullOrEmpty(password))
                {
                    controlErrores.Dispose();
                    controlErrores.SetError(txtPassword, Properties.Resources.msgControlErroresPassword);
                }
                else
                {
                    controlErrores.Dispose();

                    if (Login.Autenticar(nombre, password))
                    {
                        this.DialogResult = DialogResult.OK;
                        //Creación del usuario actual del sistema
                        cargarDatosUssAutorizado(nombre);
                        if (!cargarOpcionesUsuario())
                            MessageBox.Show(Properties.Resources.msgLoginErrorCargaOpciones, Properties.Resources.msgLoginErrorCargaOpcionesTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        intentoLoginFallido();
                    }
                }
            }
        }

        private void intentoLoginFallido()
        {
            numIntentos++;
            if (numIntentos < MAX_NUM_INTENTOS)
            {
                MessageBox.Show(string.Format(Properties.Resources.msgLoginErrorTexto, (MAX_NUM_INTENTOS - numIntentos)), Properties.Resources.msgLoginErrorTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Utils.Utilidades.activarTTS(string.Format(Properties.Resources.msgLoginErrorTexto, (MAX_NUM_INTENTOS - numIntentos)));
                vaciarFormulario();
            }
            else
            {
                MessageBox.Show(Properties.Resources.msgLoginErrorMaxIntentosTexto, Properties.Resources.msgLoginErrorMaxIntentosTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Utils.Utilidades.activarTTS(Properties.Resources.msgLoginErrorMaxIntentosTexto);
                this.DialogResult = DialogResult.Abort;
                bloqueadoAcceso = true;
                vaciarFormulario();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        private void cargarDatosUssAutorizado(string usuario)
        {
            string[] datosUsuario = Utils.ConexionBD.consultarRegistroBD("SELECT * FROM usuario WHERE usuario = '" + usuario + "';")[0];
            Utils.Utilidades.usuarioActual = new Usuario(usuario, Convert.ToInt32(datosUsuario[3]));
            Utils.Utilidades.usuarioActual.Id = Convert.ToInt32(datosUsuario[0]);
            Utils.Utilidades.usuarioActual.Nombre = datosUsuario[4];
            Utils.Utilidades.usuarioActual.Apellido1 = datosUsuario[5];
            Utils.Utilidades.usuarioActual.Apellido2 = datosUsuario[6];
            Utils.Utilidades.usuarioActual.Email = datosUsuario[7];
        }

        private bool cargarOpcionesUsuario()
        {
            bool conectado = false;
            try
            {
                List<string[]> listaOpcionesGen = ConexionBD.consultarRegistroBD("SELECT nombre, valor FROM config ORDER BY id;");
                List<string[]> listaOpcionesUsuario = ConexionBD.consultarRegistroBD("SELECT nombre, configusuario.valor FROM "
                    + "config, configusuario WHERE configusuario.idconfig=config.id AND idusuario = " + Utils.Utilidades.usuarioActual.Id + " ORDER BY config.id;");
                foreach (string[] opc in listaOpcionesGen)
                {
                    int cont = 0;
                    foreach (string[] opcU in listaOpcionesUsuario)
                    {
                        if (opc[0] == opcU[0])
                            cont++;
                    }
                    if (cont == 0)
                        listaOpcionesUsuario.Add(opc);
                }
                listaOpcionesGen = null;
                Utilidades.opcsGen = null;
                Utilidades.opcsGen = new OpcsGen(listaOpcionesUsuario);
                Inicio.log.Registro.Info("Carga de las opciones específicas del usuario. OK");
                conectado = true;
            }
            catch (Exception ex)
            {
                Inicio.log.Registro.Error("Carga de las opciones específicas del usuario. Fallida ", ex);
            }
            return conectado;
        }

        public bool getBloqueadoAcceso()
        {
            return bloqueadoAcceso;
        }

        private void vaciarFormulario()
        {
            if (!mantenerUsuario)
                txtNombre.Clear();
            txtPassword.Clear();
        }

        #region Login Facial

        private void inicializarDeteccionFacial()
        {
            cargarPatronesDeteccionFacial();
            iniciarCamara();
        }


        private void iniciarCamara()
        {
            //Inicia la webcam
            camaraCapturadora = new Capture();
            camaraCapturadora.QueryFrame();
            //Inicia el evento capturador de imágenes
            Application.Idle += new EventHandler(FrameGrabber);
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camaraCapturadora != null)
                desactivarCamara();
        }

        private void desactivarCamara()
        {
            camaraCapturadora.Dispose();
            camaraCapturadora = null;
            Application.Idle -= new EventHandler(FrameGrabber);
            imageBoxFrameGrabber.Visible = false;
        }

        private void guardarImagenUsuarioEntrenamiento()
        {
            try
            {
                //Imagen de la cámara en escala de grises
                gray = camaraCapturadora.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //Fotos de rostros almacenadas
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                patronCara,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                foreach (MCvAvgComp f in facesDetected[0])
                {
                    imagenUssRegistrado = fotogramaActual.Copy(f.rect).Convert<Gray, byte>();
                    break;//Para que solo detecte el primer rostro de la imagen, por si hay otras personas en el fotograma.
                }
                // Cambiar el tamaño patronCara imagen detectada por la fuerza de comparar el mismo tamaño con la
                // Imagen de prueba con el método de tipo de interpolación cúbica
                imagenUssRegistrado = resultado.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Utils.OperBD.insertarImagenUsuarioLoginFacial(imagenUssRegistrado.Bitmap, idUsuario);
                imageBoxFrameGrabber.Image = imagenUssRegistrado;
                MessageBox.Show(Properties.Resources.msgLoginNuevaImagenUss, Properties.Resources.msgLoginNuevaImagenUssTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.msgLoginErrorSinImagenUss + ex, Properties.Resources.msgLoginErrorSinImagenUssTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cargarPatronesDeteccionFacial()
        {
            //Carga el patron de rostros
            patronCara = new HaarCascade("./Resources/haarcascade_frontalface_default.xml");

            List<Object[]> listaImagenUsuario = ConexionBD.consultarImagenesLoginFacial("SELECT usuarioimagen.imagen, usuario FROM usuarioimagen INNER JOIN usuario ON usuarioimagen.idusuario = usuario.idusuario;");
            for (int i = 0; i < listaImagenUsuario.Count; i++)
            {
                Bitmap masterImage = (Bitmap)listaImagenUsuario[i][0];

                // Convierte las imágenes a escala de grises, si no lo estuviesen
                Image<Gray, Byte> normalizedMasterImage = new Image<Gray, Byte>(masterImage);
                imagenesUssRegistrados.Add(normalizedMasterImage);
                listaNombres.Add((string)listaImagenUsuario[i][1]);
            }
        }

        private void FrameGrabber(object sender, EventArgs e)
        {
            usuarioReconocido = "";
            //Captura el fotograma actual de la cámara
            fotogramaActual = camaraCapturadora.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            //Convierte el fotograma actual a escala de grises
            gray = fotogramaActual.Convert<Gray, Byte>();

            //Detector de caras, compara con el patrón de rostros
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(patronCara, 1.1, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //MCvAvgComp[][] facesDetected  = gray.DetectHaarCascade(patronCara, 1.4, 15,HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,new Size(20, 20));

            //Recorre todas las imágenes de los usuarios almacenadas, los rostros conocidos, para comparar el actual
            foreach (MCvAvgComp f in facesDetected[0])
            {
                resultado = fotogramaActual.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                // Dibujar el patrón Cara detectada en el canal 0 (gris) con color azul
                fotogramaActual.Draw(f.rect, new Bgr(Color.Blue), 2);

                if (imagenesUssRegistrados.ToArray().Length != 0)
                {
                    // TermCriteria para el reconocimiento patronCara con los números de imágenes formados como máximo de iteraciones
                    MCvTermCriteria termCrit = new MCvTermCriteria(listaNombres.Count, 0.001);

                    //Eigen patronCara recognizer
                    //Se va reduciendo el ajustePrecisionRec para que aumente la precisión de coincidencia con la BD, minimiza los errores de coincidencia con la image.
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(imagenesUssRegistrados.ToArray(), listaNombres.ToArray(), ajustePrecisionRec -= 5, ref termCrit);
                    Console.WriteLine(ajustePrecisionRec);
                    usuarioReconocido = recognizer.Recognize(resultado);
                    if (!String.IsNullOrEmpty(usuarioReconocido) && modoLoginFacial != Const.LOGINFACIAL_MODO_ACCESO.Entrenamiento)
                    {
                        // Dibujar la etiqueta de cada patronCara detectado y reconocido
                        fotogramaActual.Draw(usuarioReconocido, ref tipoLetra, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                        numReconocimientos++;
                        barraNivelPrecision.Visible = true;
                        lblNivelPrecision.Visible = true;
                        barraNivelDeteccion.Visible = true;
                        lblNivelDeteccion.Visible = true;
                        if ((ajustePrecisionRec - 2500) * -1 <= barraNivelPrecision.Maximum)
                            barraNivelPrecision.Value = (ajustePrecisionRec - 2500) * -1;
                        if (numReconocimientos <= barraNivelDeteccion.Maximum)
                            barraNivelDeteccion.Value = numReconocimientos;
                        if (numReconocimientos >= barraNivelDeteccion.Maximum)
                        {
                            barraNivelPrecision.Visible = false;
                            lblNivelPrecision.Visible = false;
                            barraNivelDeteccion.Visible = false;
                            lblNivelDeteccion.Visible = false;
                            desactivarCamara();
                            txtNombre.Text = usuarioReconocido;
                            txtNombre.Enabled = false;
                            grpUssPass.Visible = true;
                            imgLogin.Visible = true;
                            imgLogin.Image = Properties.Resources.check;
                            btnAceptar.Visible = true;
                            mantenerUsuario = true;
                            this.Refresh();
                        }
                    }
                    else
                    {
                        fotogramaActual.Draw(f.rect, new Bgr(Color.Red), 2);
                        if (modoLoginFacial != Const.LOGINFACIAL_MODO_ACCESO.Entrenamiento)
                        {
                            numReconDesconocido++;
                            fotogramaActual.Draw(Properties.Resources.msgLoginPersonaDesconocida, ref tipoLetra, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                            barraNivelPrecision.Visible = true;
                            lblNivelPrecision.Visible = true;
                            barraNivelDeteccion.Visible = true;
                            lblNivelDeteccion.Visible = true;
                            if (-1 * (ajustePrecisionRec - 2500) <= barraNivelPrecision.Maximum)
                                barraNivelPrecision.Value = -1 * (ajustePrecisionRec - 2500);
                            if (numReconDesconocido <= barraNivelDeteccion.Maximum)
                                barraNivelDeteccion.Value = numReconDesconocido;
                            if (numReconDesconocido >= barraNivelDeteccion.Maximum)
                            {
                                barraNivelPrecision.Visible = false;
                                lblNivelPrecision.Visible = false;
                                barraNivelDeteccion.Visible = false;
                                lblNivelDeteccion.Visible = false;
                                desactivarCamara();
                                imgLogin.Visible = true;
                                imgLogin.Image = Properties.Resources.locked;
                                intentoLoginFallido();
                                txtNombre.Enabled = true;
                                txtPassword.Enabled = true;
                                grpUssPass.Visible = true;
                                imgLogin.Visible = true;
                                btnAceptar.Visible = true;
                                this.Refresh();
                            }
                        }
                        else
                            fotogramaActual.Draw(Properties.Resources.msgLoginPersonaDetectada, ref tipoLetra, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                    }

                }
            }
            imageBoxFrameGrabber.Image = fotogramaActual;
        }

        #region Eventos

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            btnAceptar.Visible = true;
            lblPass.Visible = true;
            txtPassword.Visible = true;
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (modoAcceso == Const.LOGIN_MODO_IDENTIFICACION.TARJETA && e.KeyCode == Keys.Enter)
            {
                List<string[]> usuario = Utils.ConexionBD.consultarRegistroBD("SELECT idUsuario, usuario FROM usuario WHERE codigo LIKE '" + txtNombre.Text + "';");
                if (usuario.Count > 0)
                {
                    txtNombre.Text = usuario[0][1];
                    txtPassword.Focus();
                    imgLogin.Image = OperBD.consultarImagenUsuario(Convert.ToInt32(usuario[0][0]));
                }
                else
                {
                    intentoLoginFallido();
                }
            }
        }

        #endregion
    }

    #endregion
}
