/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace GesMerCa
{
    partial class FrmSplash : Form
    {
        public static bool cargaProcesada;
        private int contEjec;
        private int procesoOK;

        public FrmSplash()
        {
            Inicio.log = new Utils.Log();
            Inicio.log.Registro.Info("Init - Splash de la app");

            InitializeComponent();
            //this.labelProductName.Text = AssemblyProduct;
            //this.descriptionProductName.Text = AssemblyDescription;
            this.labelCopyright.Text = "v " + AssemblyVersion + " " + AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;

            cargaProcesada = false;
            contEjec = 0;
            procesoOK = 0;
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            Inicio.log.Registro.Info("Shown - Splash de la app");

            temporizadorCarga.Interval = 3000;
            //temporizadorCarga.Interval = 3;
            temporizadorCarga.Enabled = true;
            System.Threading.Thread hilo = new System.Threading.Thread(delegate ()
            {
                temporizadorCarga.Start();
            });
            Inicio.log.Registro.Info("Proceso carga - Splash de la app");
        }

        private void procesoCarga(object sender, EventArgs e)
        {
            switch (contEjec)
            {
                case 0:
                    setMensajeSplash(Properties.Resources.msgSplashCheckBD);
                    contEjec++;
                    break;
                case 1:
                    if (Utils.CargaInicio.comprobarConexionBD(lblCargando, temporizadorCarga))
                    {
                        procesoOK++;
                    }
                    else
                    {
                        comprobarProcesoCarga();
                    }
                    contEjec++;
                    break;
                case 2:
                    setMensajeSplash(Properties.Resources.msgSplashCheckInternet);
                    contEjec++;
                    break;
                case 3:
                    if (Utils.CargaInicio.comprobarAccesoInternet(lblCargando, temporizadorCarga))
                    {
                        procesoOK++;
                    }
                    contEjec++;
                    break;
                case 4:
                    setMensajeSplash(Properties.Resources.msgSplashCargandoElementos);
                    contEjec++;
                    break;
                case 5:
                    setMensajeSplash(Properties.Resources.msgSplashCargandoOpcsGen);
                    contEjec++;
                    break;
                case 6:
                    if (Utils.CargaInicio.cargarOpcionesGenerales(lblCargando, temporizadorCarga))
                    {
                        procesoOK++;
                    }
                    else
                    {
                        comprobarProcesoCarga();
                    }
                    contEjec++;
                    break;
                default:
                    if (procesoOK >= Utils.Const.NUM_PROCESOS_CARGA) //Número de procesos de carga (sin mensajes, solo funcionalidad)
                        cargaProcesada = true;
                    comprobarProcesoCarga();
                    break;
            }
        }

        private void comprobarProcesoCarga()
        {
            temporizadorCarga.Stop();
            Inicio.log.Registro.Info("Fin proceso carga - Carga completa procesada: " + cargaProcesada);
            if (cargaProcesada)
            {
                Utils.Utilidades.activarTTS(AssemblyTitle + Properties.Resources.msgInfoTTS_1);
                this.Close();
            }
            else
            {
                temporizadorFinal.Stop();
                MessageBox.Show(Properties.Resources.msgSplashErrorCarga, Properties.Resources.msgSplashErrorCargaTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Inicio.log.Registro.Error("Erros Splash - Procesos de carga ejecutados: " + procesoOK + "/" + contEjec / 2);
                Close();
            }
        }

        public void setMensajeSplash(string texto)
        {
            lblCargando.Text = texto;
            lblCargando.Refresh();
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

    }
}