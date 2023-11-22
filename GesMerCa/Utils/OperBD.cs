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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesMerCa.Utils
{
    class OperBD
    {
        public static List<string[]> consultaTodosUsuarios()
        {
            List<string[]> resultado = null;
            try
            {
                resultado = Utils.ConexionBD.consultarRegistroBD("SELECT * FROM usuario;");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: " + ex2.Message);
            }
            return resultado;
        }

        //Método de PRUEBA
        public static void insertarLOG()
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarRegistroBD("INSERT INTO `recepciona`.`log` (`Id`, `Date`, `Username`, `Thread`, `Level`, `Logger`, `Message`, `Exception`) VALUES (NULL, '2016-05-02 00:00:00', 'prueba', 'prueba', '', '', '', NULL);");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: " + ex2.Message);
            }
        }

        internal static int insertarProveedor(string[] valores)
        {
            int filasAfectadas = -1;
            try
            {
                filasAfectadas = Utils.ConexionBD.modificarRegistroBD("INSERT proveedor (`id`, `tipo_id`, `cif_nif`, `nombre`, `direccion`, `localidad`, `telefono`, `email`, `web`, `observaciones`)" +
                    " VALUES ('" + valores[0] + "', '" + valores[1] + "', '" + valores[2] + "', '" + valores[3] + "', '" + valores[4] + "', '" + valores[5] + "', '" + valores[6] + "', '" + valores[7] + "', '" + valores[8] + "', );");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: " + ex2.Message);
            }
            return filasAfectadas;
        }

        public static string consultarRolUsuario(int idRol)
        {
            return ConexionBD.consultarRegistroBD("SELECT nombre FROM rol WHERE idRol=" + idRol + ";")[0][0];
        }

        public static List<string[]> consultarListadoRoles()
        {
            return Utils.ConexionBD.consultarRegistroBD("SELECT idRol, nombre FROM rol");
        }

        public static Image consultarImagenUsuario(int idUsuario)
        {
            Image imagen = null;
            try
            {
                imagen = Utils.ConexionBD.consultarImagenBD("SELECT imagen FROM usuario WHERE idusuario=" + idUsuario + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: " + ex2.Message);
            }
            return imagen;
        }

        public static void insertarImagenUsuario(Image img, int idUsuario, System.Drawing.Imaging.ImageFormat extension)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarImagenBD("UPDATE usuario SET imagen = @imagen WHERE idusuario=" + idUsuario + ";", img, extension);
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static int consultarImagenesUsuarioLoginFacial(int idUsuario)
        {
            int filasAfectadas = -1;
            try
            {
                filasAfectadas = Convert.ToInt32(Utils.ConexionBD.consultarRegistroBD("SELECT COUNT(imagen) FROM usuarioimagen WHERE idusuario=" + idUsuario + ";")[0][0]);
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }

        public static void insertarImagenUsuarioLoginFacial(Image img, int idUsuario)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarImagenBD(
                    "INSERT usuarioimagen (idUsuario, imagen, fechacaptura) VALUES (" + idUsuario + ",@imagen, NOW());", img, System.Drawing.Imaging.ImageFormat.Bmp);
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void eliminarImagenesUsuarioLoginFacial(int idUsuario)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.modificarRegistroBD(
                    "DELETE FROM usuarioimagen WHERE idUsuario = " + idUsuario + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void insertarNuevoModulo(string nombreModulo)
        {
            try
            {
                if (Convert.ToInt32(Utils.ConexionBD.consultarRegistroBD("SELECT COUNT(modulo) FROM permiso WHERE modulo LIKE'" + nombreModulo + "'")[0][0]) <= 1)
                {
                    int filasAfectadas = Utils.ConexionBD.insertarRegistroBD(
                    "INSERT permiso (modulo, descripcion) VALUES ('" + nombreModulo + "', '');");
                }
                else
                {
                    MessageBox.Show(Properties.Resources.msgOperBDErrorModulo, Properties.Resources.msgOperBDErrorModuloTitulo, MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void eliminarModulo(string nombreModulo)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarRegistroBD(
                    "DELETE FROM permiso WHERE modulo LIKE '" + nombreModulo + "';");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void modificarModuloRol(string nombreModulo, int idRol, bool lectura)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarRegistroBD(
                    "UPDATE permisodenegadoporrol SET lectura = " + lectura + " WHERE idRol = " + idRol + " AND idPermiso = (SELECT idPermiso FROM permiso WHERE modulo LIKE '" + nombreModulo + "');");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void insertarModuloRol(string nombreModulo, int idRol, bool lectura)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarRegistroBD(
                    "INSERT permisodenegadoporrol (idRol, idPermiso, lectura) VALUES (" + idRol + ",(SELECT idPermiso FROM permiso WHERE modulo LIKE '" + nombreModulo + "'), " + Convert.ToInt32(lectura) + ");");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }

        public static void eliminarModuloRol(string nombreModulo, int idRol)
        {
            try
            {
                int filasAfectadas = Utils.ConexionBD.insertarRegistroBD(
                    "DELETE FROM permisodenegadoporrol WHERE idRol = " + idRol + " AND idPermiso = (SELECT idPermiso FROM permiso WHERE modulo LIKE '" + nombreModulo + "');");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
        }
        public static List<string[]> consultarModulosDisponibles(int idRol)
        {
            List<string[]> resultado = null;
            try
            {
                resultado = Utils.ConexionBD.consultarRegistroBD(
                    "SELECT modulo, lectura, escritura FROM permiso " +
                    "INNER JOIN permisodenegadoporrol " +
                    "ON permiso.idpermiso=permisodenegadoporrol.idpermiso " +
                    "WHERE permisodenegadoporrol.idrol=" + idRol + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return resultado;
        }

        public static List<string[]> consultarModulosRol(int idRol)
        {
            List<string[]> resultado = null;
            try
            {
                resultado = Utils.ConexionBD.consultarRegistroBD("SELECT * FROM permisodenegadoporrol WHERE idrol=" + idRol + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return resultado;
        }

        public static List<string[]> consultarListadoPermisos()
        {
            List<string[]> resultado = null;
            try
            {
                resultado = Utils.ConexionBD.consultarRegistroBD("SELECT * FROM permiso;");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return resultado;
        }

        public static int actualizarOpciones(int idOpcion, Utils.Const.TIPO_OPCION_CONFIG tipoOpc, string[] valores)
        {
            int filasAfectadas = -1;
            try
            {
                if (tipoOpc == Const.TIPO_OPCION_CONFIG.GENERAL)
                {
                    filasAfectadas = Utils.ConexionBD.modificarRegistroBD("UPDATE config SET valor = '" + valores[1] +
                        "', titulo = '" + valores[0] + "', dominio = '" + valores[2] + "', descripcion = '" + valores[3] +
                        "' WHERE id =" + idOpcion + ";");
                }
                else
                {
                    filasAfectadas = Utils.ConexionBD.modificarRegistroBD("UPDATE configusuario SET valor='"
                        + valores[0] + "', descripcion ='" + valores[1] + "' WHERE id =" + idOpcion + ";");
                }
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }

        public static int insertarOpcionesUsuario(int idOpcion, Utils.Const.TIPO_OPCION_CONFIG tipoOpc, string[] valores)
        {
            int filasAfectadas = -1;
            try
            {
                if (tipoOpc == Const.TIPO_OPCION_CONFIG.USUARIO)
                {
                    //Console.WriteLine("INSERT configusuario (idconfig, idusuario, valor, descripcion)"
                    //    + " VALUES ((SELECT id FROM config WHERE nombre = '" + valores[0] + "'), " + Utils.Utilidades.usuarioActual.Id +
                    //      ", '" + valores[1] + "', '" + valores[3] + "');");
                    filasAfectadas = Utils.ConexionBD.modificarRegistroBD("INSERT configusuario (idconfig, idusuario, valor, descripcion)"
                        + " VALUES ((SELECT id FROM config WHERE nombre = '" + valores[0] + "'), " + Utils.Utilidades.usuarioActual.Id +
                          ", '" + valores[1] + "', '" + valores[3] + "');");
                }
                else
                {
                    filasAfectadas = Utils.ConexionBD.modificarRegistroBD("INSERT config (nombre, valor, titulo, descripcion, dominio)"
                        + " VALUES ('" + valores[0] + "', '" + valores[1] + "', '" + valores[2] + "', '" + valores[3] + "', '" + valores[4] + "');");
                }
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }

        public static int modificarUsuario(string[] valores)
        {
            int filasAfectadas = -1;
            try
            {
                Console.WriteLine("UPDATE usuario SET nombre = '" + valores[3] + "', apellido1 = '" + valores[4] + "', apellido2 = '" + valores[5] + "', email = '" + valores[6] + "', idRol = " + valores[8] + " WHERE idusuario = " + valores[0] + ";");
                filasAfectadas = Utils.ConexionBD.modificarRegistroBD("UPDATE usuario SET nombre = '" + valores[3] + "', apellido1 = '" + valores[4] + "', apellido2 = '" + valores[5] + "', email = '" + valores[6] + "', idRol = " + valores[8] + " WHERE idusuario = " + valores[0] + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }

        public static int modificarRolUsuario(int id, int idRol)
        {
            int filasAfectadas = -1;
            try
            {
                Console.WriteLine("UPDATE usuario SET idRol = " + idRol + " WHERE idusuario = " + id + ";");
                filasAfectadas = Utils.ConexionBD.modificarRegistroBD("UPDATE usuario SET idRol = " + idRol + " WHERE idusuario = " + id + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }

        public static int eliminarUsuario(string[] valores)
        {
            int filasAfectadas = -1;
            try
            {
                filasAfectadas = Utils.ConexionBD.modificarRegistroBD("DELETE FROM usuario WHERE idusuario = " + valores[0] + ";");
            }
            catch (MySqlException ex)
            {
                Inicio.log.Registro.Error("Comprobación conexión BD. Fallida ", ex);
            }
            catch (Exception ex2)
            {
                Inicio.log.Registro.Error("Error general: ", ex2);
            }
            return filasAfectadas;
        }
    }
}
