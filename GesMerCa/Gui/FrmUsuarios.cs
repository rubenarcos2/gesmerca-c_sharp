/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesMerCa
{
    public partial class FrmUsuarios : Form
    {
        #region Atributos

        private MySqlDataAdapter adaptador;
        private DataTable dataTable;
        private MySqlCommandBuilder cmdBuilder;
        private BindingSource bndSource;

        private FrmAltaUsuarios frmAltaUsuarios;
        private FrmLogin frmLogin;

        #endregion

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        #region Evento formulario

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            adaptador = Utils.ConexionBD.getAdapterBD("SELECT idusuario, usuario AS Usuario, idRol AS Rol, nombre AS Nombre, apellido1 AS 'Primer apellido', apellido2 AS 'Segundo apellido', email AS 'E-Mail', imagen AS 'Imagen' FROM usuario");
            try
            {
                cmdBuilder = new MySqlCommandBuilder(adaptador);
                adaptador.UpdateCommand = cmdBuilder.GetUpdateCommand();
                adaptador.DeleteCommand = cmdBuilder.GetDeleteCommand();
                adaptador.InsertCommand = cmdBuilder.GetInsertCommand();

                dataTable = new DataTable();
                adaptador.Fill(dataTable);

                bndSource = new BindingSource();
                bndSource.DataSource = dataTable;

                dataGridUsuarios.DataSource = bndSource;
                dataGridUsuarios.Columns[0].Visible = false;
                dataGridUsuarios.Columns["Rol"].Visible = false;
                dataGridUsuarios.Columns[0].ReadOnly = true;
                dataGridUsuarios.Columns[1].ReadOnly = true;
                dataGridUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataTable.AcceptChanges();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(Properties.Resources.msgUsuariosErrorDatosBD + ex, Properties.Resources.msgUsuariosErrorDatosBDTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex2)
            {
                MessageBox.Show(Properties.Resources.msgUsuariosErrorDatosGeneralBD + ex2, Properties.Resources.msgUsuariosErrorDatosBDTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUsuarios_Shown(object sender, EventArgs e)
        {
            setCmbRol();
            //Inserción de los botones
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            dataGridUsuarios.Columns.Add(btnModificar);
            btnModificar.HeaderText = "";
            btnModificar.Text = Properties.Resources.btnModificar;
            btnModificar.Name = "btnModificar";
            btnModificar.UseColumnTextForButtonValue = true;
            btnModificar.Width = 50;
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            dataGridUsuarios.Columns.Add(btnEliminar);
            btnEliminar.HeaderText = "";
            btnEliminar.Text = Properties.Resources.btnEliminar;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.Width = 50;
            setEdicionCeldas(true);
        }

        private void setCmbRol()
        {
            //Combo rol de usuario
            DataGridViewComboBoxColumn cmbRol = new DataGridViewComboBoxColumn();
            cmbRol.Name = "Rol usuario";
            List<string[]> listaRoles = Utils.OperBD.consultarListadoRoles();
            var dict = new Dictionary<int, string>();
            foreach (string[] rol in listaRoles)
            {
                dict.Add(Convert.ToInt32(rol[0]), rol[1]);
            }
            cmbRol.DataSource = new BindingSource(dict, null);
            cmbRol.DisplayMember = "Value";
            cmbRol.ValueMember = "Key";
            cmbRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridUsuarios.Columns.Add(cmbRol);
            foreach (DataGridViewRow fila in dataGridUsuarios.Rows)
            {
                dataGridUsuarios.Rows[fila.Index].Cells["Rol usuario"].Value = dataGridUsuarios.Rows[fila.Index].Cells["Rol"].Value;
            }
        }

        #endregion

        private void AddImagenUsuario()
        {
            Image imgUsuario = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = Properties.Resources.msgAbrirImagenUsuarioTitulo;
            dlg.Filter = Properties.Resources.msgAbrirImagenUsuario;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgUsuario = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
            if (imgUsuario != null)
            {
                Utils.OperBD.insertarImagenUsuario(imgUsuario, Convert.ToInt32(dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString()), imgUsuario.RawFormat);
                dataGridUsuarios.Refresh();
                this.Refresh();
            }
        }

        private void setEdicionCeldas(bool estado)
        {
            for (int i = 0; i < dataGridUsuarios.RowCount; i++)//No afecta al nombre de usuario
            {
                for (int j = 2; j < dataGridUsuarios.ColumnCount; j++)
                {
                    dataGridUsuarios.Rows[i].Cells[j].ReadOnly = estado;
                }
            }
        }

        #region Eventos datagrid

        private void dataGridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridUsuarios.ColumnCount - 2 && e.RowIndex >= 0)
            {
                for (int i = 0; i < dataGridUsuarios.ColumnCount - 2; i++)//No afecta a la imagen ni los botones
                {
                    if (dataGridUsuarios.Rows[e.RowIndex].Cells[i].ReadOnly)
                    {
                        dataGridUsuarios.Rows[e.RowIndex].Cells[i].ReadOnly = false;
                        dataGridUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        dataGridUsuarios.Rows[e.RowIndex].Cells[i].ReadOnly = true;
                        dataGridUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
            else if (e.ColumnIndex == dataGridUsuarios.ColumnCount - 1 && e.RowIndex >= 0)
            {
                if (MessageBox.Show(Properties.Resources.msgEliminarUsuario +
                    dataGridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString() +
                    "?", Properties.Resources.msgEliminarUsuarioTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] valores = new string[dataGridUsuarios.ColumnCount - 2];
                    for (int i = 0; i < dataGridUsuarios.ColumnCount - 3; i++)
                    {
                        if (String.IsNullOrEmpty(dataGridUsuarios.Rows[e.RowIndex].Cells[i].Value.ToString()))
                            valores[i] = null;
                        else
                            valores[i] = dataGridUsuarios.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                    Utils.OperBD.eliminarUsuario(valores);
                    valores = null;
                }
            }
        }

        private void dataGridUsuarios_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode)
            {
                if (MessageBox.Show(Properties.Resources.msgGuardarCambiosUsuario +
                                    dataGridUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString() +
                                    "?", Properties.Resources.msgGuardarCambiosUsuarioTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] valores = new string[dataGridUsuarios.ColumnCount - 2];
                    for (int i = 0; i < dataGridUsuarios.ColumnCount - 2; i++)
                    {
                        if (String.IsNullOrEmpty(dataGridUsuarios.Rows[e.RowIndex].Cells[i].Value.ToString()))
                            valores[i] = null;
                        else
                            valores[i] = dataGridUsuarios.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                    Utils.OperBD.modificarUsuario(valores);
                    valores = null;
                }
                dataGridUsuarios.Update();
                dataGridUsuarios.Refresh();
                setEdicionCeldas(true);
            }
        }

        #endregion

        #region Eventos botones

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            if (frmAltaUsuarios == null)
            {
                frmAltaUsuarios = new FrmAltaUsuarios();
                frmAltaUsuarios.MdiParent = this.MdiParent.MdiParent;
                //frmAltaUsuarios.Owner = this;
                //frmAltaUsuarios.StartPosition = FormStartPosition.Manual;
                //frmAltaUsuarios.Location = new Point((this.ClientSize.Width - frmAltaUsuarios.Width) / 2, (this.ClientSize.Height - frmAltaUsuarios.Height) / 2);
                frmAltaUsuarios.ShowDialog();
                frmAltaUsuarios.BringToFront();
                frmAltaUsuarios.Focus();
                frmAltaUsuarios.FormClosed += new FormClosedEventHandler(cierreFrmAltaUsuarios);
            }
            else
            {
                frmAltaUsuarios.Activate();
            }
        }

        private void cierreFrmAltaUsuarios(object sender, FormClosedEventArgs e)
        {
            frmAltaUsuarios = null;
        }

        private void btnAltaLoginFacial_Click(object sender, EventArgs e)
        {
            int idUsuario = -1;
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                idUsuario = Convert.ToInt32(dataGridUsuarios.SelectedRows[0].Cells[0].Value.ToString());
                if (frmLogin == null)
                {
                    if (Utils.OperBD.consultarImagenesUsuarioLoginFacial(idUsuario) > 0)
                    {
                        if (MessageBox.Show(Properties.Resources.msgGuardarImagenesLoginFacial, Properties.Resources.msgGuardarImagenesLoginFacialTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            Utils.OperBD.eliminarImagenesUsuarioLoginFacial(idUsuario);
                        }
                    }
                    frmLogin = new FrmLogin(Utils.Const.LOGIN_MODO_IDENTIFICACION.FACIAL, Utils.Const.LOGINFACIAL_MODO_ACCESO.Entrenamiento, idUsuario);
                    //frmAltaUsuarios.MdiParent = this.MdiParent.MdiParent;
                    //frmLogin.StartPosition = FormStartPosition.Manual;
                    //frmLogin.Location = new Point((this.ClientSize.Width - frmAltaUsuarios.Width) / 2, (this.ClientSize.Height - frmAltaUsuarios.Height) / 2);
                    frmLogin.ShowDialog();
                    frmLogin.BringToFront();
                    frmLogin.Focus();
                    frmLogin.FormClosed += new FormClosedEventHandler(cierreFrmAltaUsuarios);
                }
                else
                {
                    frmLogin.Activate();
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.msgSeleccionarUsuario, Properties.Resources.msgSeleccionarUsuarioTitulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (bndSource.Filter == null)
            {
                string filtro = string.Format("{0} >= {1}", dataGridUsuarios.Columns[0].Name, "0");
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                    filtro += string.Format(" AND [{0}] LIKE '%{1}%'", dataGridUsuarios.Columns[1].Name, txtUsuario.Text);
                if (!string.IsNullOrEmpty(txtNombre.Text))
                    filtro += string.Format(" AND [{0}] LIKE '%{1}%'", dataGridUsuarios.Columns[3].Name, txtNombre.Text);
                if (!string.IsNullOrEmpty(txtApellido1.Text))
                    filtro += string.Format(" AND [{0}] LIKE '%{1}%'", dataGridUsuarios.Columns[4].Name, txtApellido1.Text);
                if (!string.IsNullOrEmpty(txtApellido2.Text))
                    filtro += string.Format(" AND [{0}] LIKE '%{1}%'", dataGridUsuarios.Columns[5].Name, txtApellido2.Text);
                Console.WriteLine(filtro);
                bndSource.Filter = filtro;
                setCmbRol();
                dataGridUsuarios.Update();
                dataGridUsuarios.Refresh();
                btnFiltrar.Image = Properties.Resources.filtroOn;
                grpFiltroUsuarios.Enabled = false;
            }
            else
            {
                bndSource.Filter = null;
                setCmbRol();
                dataGridUsuarios.Update();
                dataGridUsuarios.Refresh();
                grpFiltroUsuarios.Enabled = true;
                foreach (var ctl in grpFiltroUsuarios.Controls)
                {
                    if (ctl is TextBox)
                    {
                        TextBox txt = (TextBox)ctl;
                        txt.Clear();
                    }
                }
                btnFiltrar.Image = Properties.Resources.Filter;
            }

        }

        private void btnCambiarImgUss_Click(object sender, EventArgs e)
        {
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                AddImagenUsuario();
            }
            else
            {
                MessageBox.Show(Properties.Resources.msgSeleccionarUsuario, Properties.Resources.msgSeleccionarUsuarioTitulo, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        #endregion
    }
}
