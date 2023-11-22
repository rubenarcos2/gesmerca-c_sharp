/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using GesMerCa.Objs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GesMerCa
{
    public partial class FrmSeguridad : Form
    {
        private List<Objs.Usuario> listaUssModificados;
        private List<string[]> listaPermisosRol;
        //Listas de elementos modificados para su posterior actualización en la BD
        private List<string> listaNuevoModulo;
        private List<string[]> listaModuloRol;
        private List<string[]> listaModuloModifRol;

        public FrmSeguridad()
        {
            InitializeComponent();
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            listBoxTodosUss.DisplayMember = "nombreLogin";
            listBoxTodosUss.ValueMember = "idRol";
            listBoxUssRol.DisplayMember = "nombreLogin";
            listBoxUssRol.ValueMember = "idRol";
            cmbRoles.DisplayMember = "key";
            cmbRoles.ValueMember = "value";
            cmbRolesMod.DisplayMember = "key";
            cmbRolesMod.ValueMember = "value";
            cargarListaUsuarios();
            cargarCmbRoles();
            listaPermisosRol = Utils.OperBD.consultarListadoPermisos();
            cargarListaModulos();
            //Listas de elementos modificados para su posterior actualización en la BD
            listaUssModificados = new List<Objs.Usuario>();
            listaNuevoModulo = new List<string>();
            listaModuloRol = new List<string[]>();
            listaModuloModifRol = new List<string[]>();
        }

        #region Pestaña Roles

        private void cargarListaUsuarios()
        {
            listBoxTodosUss.Items.Clear();
            foreach (string[] uss in Utils.OperBD.consultaTodosUsuarios())
            {
                Objs.Usuario usuarioModificado = new Usuario(uss[1], Convert.ToInt32(uss[3]));
                usuarioModificado.Id = Convert.ToInt32(uss[0]);
                usuarioModificado.Nombre = uss[4];
                usuarioModificado.Apellido1 = uss[5];
                usuarioModificado.Apellido2 = uss[6];
                usuarioModificado.Email = uss[7];
                listBoxTodosUss.Items.Add(usuarioModificado);
            }
        }

        private void cargarCmbRoles()
        {
            cmbRoles.Items.Clear();
            Dictionary<string, int> listaRoles = new Dictionary<string, int>();

            foreach (string[] rol in Utils.OperBD.consultarListadoRoles())
            {
                listaRoles.Add(rol[1], Convert.ToInt32(rol[0]));
            }
            foreach (System.Collections.Generic.KeyValuePair<string, int> rol in listaRoles)
            {
                cmbRoles.Items.Add(rol);
                cmbRolesMod.Items.Add(rol);
            }
        }

        private void guardarUsuarios()
        {
            try
            {
                //Graba en la BD las modificaciones de los usuarios-roles de la lista de la primera pestaña
                foreach (Objs.Usuario uss in listaUssModificados)
                {
                    Utils.OperBD.modificarRolUsuario(uss.Id, uss.IdRol);
                }
                //Graba en la BD las modificaciones de la lista central de la segunda pestaña.
                //Los nuevos elementos a los que se le asignará restricción.
                foreach (string modulo in listaNuevoModulo)
                {
                    Utils.OperBD.insertarNuevoModulo(modulo);
                }
                //Graba en la BD las modificaciones de la lista de la derecha de la segunda pestaña.
                //Los elementos a los que se le asignará restricción según el rol seleccionado.
                foreach (string[] modulo in listaModuloRol)
                {
                    //False es el valor por defecto, si este cambia, luego será modificado con el correcto en el evento de cambio de check (siguiente línea).
                    Utils.OperBD.insertarModuloRol(modulo[0], Convert.ToInt32(modulo[1]), false);
                }
                //Graba en la BD las modificaciones de la lista de la derecha de la segunda pestaña.
                //Los elementos a los que se le asignará restricción según el rol seleccionado.
                foreach (string[] modulo in listaModuloModifRol)
                {
                    Utils.OperBD.modificarModuloRol(modulo[0], Convert.ToInt32(modulo[1]), Convert.ToBoolean(modulo[2]));
                }
            }
            catch (Exception ex)
            {
                Inicio.log.Registro.Error("ERROR en la actualización de los roles de usuario: " + ex);
                Close();
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarListaUsuarios();
            //listaUssModificados.Clear();
            listBoxUssRol.Items.Clear();
            List<Objs.Usuario> listaUsuariosDel = new List<Objs.Usuario>();
            foreach (Objs.Usuario uss in listBoxTodosUss.Items)
            {
                if (uss.IdRol == ((System.Collections.Generic.KeyValuePair<string, int>)cmbRoles.SelectedItem).Value)
                {
                    listBoxUssRol.Items.Add(uss);
                    listaUsuariosDel.Add(uss);
                }
            }
            foreach (Objs.Usuario uss in listaUsuariosDel)
            {
                listBoxTodosUss.Items.Remove(uss);
            }
            listBoxUssRol.Refresh();
            listBoxTodosUss.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddUssRol_Click(object sender, EventArgs e)
        {
            if (listBoxTodosUss.SelectedItems.Count > 0)
            {
                listBoxUssRol.Items.Add(listBoxTodosUss.SelectedItem);
                Objs.Usuario usuarioModificado = new Usuario(((Objs.Usuario)listBoxTodosUss.SelectedItem).NombreLogin, (((System.Collections.Generic.KeyValuePair<string, int>)cmbRoles.SelectedItem).Value));
                usuarioModificado.Id = ((Objs.Usuario)listBoxTodosUss.SelectedItem).Id;
                listaUssModificados.Add(usuarioModificado);
                listBoxTodosUss.Items.Remove(listBoxTodosUss.SelectedItem);
            }
        }

        private void btnDelUssRol_Click(object sender, EventArgs e)
        {
            if (listBoxUssRol.SelectedItems.Count > 0)
            {
                listBoxTodosUss.Items.Add(listBoxUssRol.SelectedItem);
                listaUssModificados.Remove((Objs.Usuario)listBoxTodosUss.SelectedItem);
                listBoxUssRol.Items.Remove(listBoxUssRol.SelectedItem);
            }

        }

        #endregion

        #region Pestaña módulos permisos

        private void cargarListaModulos()
        {
            try
            {
                listBoxTodosElementosApp.Items.Clear();
                foreach (string[] permiso in Utils.OperBD.consultarListadoPermisos())
                {
                    listBoxElementosRestringidos.Items.Add(permiso[1]);
                }

                foreach (string btn in Utils.Utilidades.listaElementosBarraHerramientas)
                {
                    if (listBoxElementosRestringidos.FindStringExact(btn) < 0)
                        listBoxTodosElementosApp.Items.Add(btn);
                }
                foreach (string btn in Utils.Utilidades.listaElementosMenuSuperior)
                {
                    if (listBoxElementosRestringidos.FindStringExact(btn) < 0)
                        listBoxTodosElementosApp.Items.Add(btn);
                }

            }
            catch (Exception ex)
            {
                Inicio.log.Registro.Error("ERROR en la actualización de los roles de usuario: " + ex);
                Close();
            }
        }

        private void cmbRolesMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRolesMod.SelectedItem != null)
            {
                listBoxElementosRestringidosRol.Items.Clear();
                listBoxElementosRestringidos.Items.Clear();
                foreach (string[] permiso in Utils.OperBD.consultarListadoPermisos())
                {
                    listBoxElementosRestringidos.Items.Add(permiso[1]);
                }
                foreach (string[] permiso in Utils.OperBD.consultarModulosDisponibles(((System.Collections.Generic.KeyValuePair<string, int>)cmbRolesMod.SelectedItem).Value))
                {
                    listBoxElementosRestringidosRol.Items.Add(permiso[0], Convert.ToBoolean(permiso[1]));
                    if (listBoxElementosRestringidos.FindStringExact(permiso[0]) > -1)
                    {
                        listBoxElementosRestringidos.Items.Remove(permiso[0]);
                    }
                }
            }
        }

        private void btnAddElmModulo_Click(object sender, EventArgs e)
        {
            if (listBoxTodosElementosApp.SelectedItems.Count > 0)
            {
                listBoxElementosRestringidos.Items.Add(listBoxTodosElementosApp.SelectedItem);
                listaNuevoModulo.Add(listBoxTodosElementosApp.SelectedItem.ToString());
                listBoxElementosRestringidos.SelectedItem = listBoxTodosElementosApp.SelectedItem;
                listBoxTodosElementosApp.Items.Remove(listBoxElementosRestringidos.SelectedItem);
            }
        }

        private void btnDelElmModulo_Click(object sender, EventArgs e)
        {
            if (listBoxElementosRestringidos.SelectedItems.Count > 0)
            {
                if (MessageBox.Show(Properties.Resources.msgSeguridadEliminarRestriccion, Properties.Resources.msgSeguridadEliminarRestriccionTitulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    if (listBoxTodosElementosApp.FindStringExact(listBoxElementosRestringidos.SelectedItem.ToString()) < 0)
                        listBoxTodosElementosApp.Items.Add(listBoxElementosRestringidos.SelectedItem);
                    listaNuevoModulo.Remove(listBoxElementosRestringidos.SelectedItem.ToString());
                    Utils.OperBD.eliminarModulo(listBoxElementosRestringidos.SelectedItem.ToString());
                    listBoxElementosRestringidos.Items.Remove(listBoxElementosRestringidos.SelectedItem);
                    Close();
                }
            }
        }

        private void btnAddModuloRol_Click(object sender, EventArgs e)
        {
            if (listBoxElementosRestringidos.SelectedItems.Count > 0)
            {
                if (listBoxElementosRestringidosRol.FindString(listBoxElementosRestringidos.SelectedItem.ToString()) > -1)
                {
                    MessageBox.Show(Properties.Resources.msgSeguridadRestriccionRepetida, Properties.Resources.msgSeguridadRestriccionRepetidaTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    listBoxElementosRestringidosRol.Items.Add(listBoxElementosRestringidos.SelectedItem);
                    listaModuloRol.Add(new string[] { listBoxElementosRestringidos.SelectedItem.ToString(), (((System.Collections.Generic.KeyValuePair<string, int>)cmbRolesMod.SelectedItem).Value).ToString() });
                    listBoxElementosRestringidos.Items.Remove(listBoxElementosRestringidos.SelectedItem);
                    listBoxElementosRestringidosRol.SelectedItem = listBoxElementosRestringidosRol.Items[listBoxElementosRestringidosRol.Items.Count - 1];
                }

            }
        }

        private void btnDelModuloRol_Click(object sender, EventArgs e)
        {
            if (listBoxElementosRestringidosRol.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Eliminar esta restricción implica que todos los usuarios de este rol la perderán.\n Quedando este módulo visible a todos los usuarios del rol seleccionado.\n\n¿Desea continuar con la eliminación de la restricción para este rol?\n(Se cerrará esta ventana para hacer efectivo los cambios)", "Eliminación de restricción de rol", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    listBoxElementosRestringidos.Items.Add(listBoxElementosRestringidosRol.SelectedItem);
                    listaModuloRol.Remove(new string[] { listBoxElementosRestringidosRol.SelectedItem.ToString(), (((System.Collections.Generic.KeyValuePair<string, int>)cmbRolesMod.SelectedItem).Value).ToString() });
                    Utils.OperBD.eliminarModuloRol(listBoxElementosRestringidosRol.SelectedItem.ToString(), (((System.Collections.Generic.KeyValuePair<string, int>)cmbRolesMod.SelectedItem).Value));
                    listBoxElementosRestringidosRol.Items.Remove(listBoxElementosRestringidosRol.SelectedItem);
                }
            }
        }


        private void listBoxElementosRestringidosRol_ItemCheck(object sender, EventArgs e)
        {
            CheckedListBox elem = (CheckedListBox)sender;
            listaModuloModifRol.Add(new string[] { elem.Items[listBoxElementosRestringidosRol.SelectedIndex].ToString(), (((KeyValuePair<string, int>)cmbRolesMod.SelectedItem).Value).ToString(), listBoxElementosRestringidosRol.GetItemChecked(listBoxElementosRestringidosRol.SelectedIndex).ToString() });
        }

        #endregion

        private void FrmSeguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listaUssModificados.Count > 0 || listaNuevoModulo.Count > 0 || listaModuloRol.Count > 0 || listaModuloModifRol.Count > 0)
            {
                if (MessageBox.Show("Hay usuarios a los que se les ha cambiado el rol.\n\n¿Desea guardar los cambios?", "Guardar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    guardarUsuarios();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

    }
}
