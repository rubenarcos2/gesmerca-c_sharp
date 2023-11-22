/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using GesMerCa.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesMerCa.Objs
{
    class Login
    {
        public static bool Autenticar(string usuario, string password)
        {
            string sql = @"SELECT COUNT(*)
                              FROM usuario
                              WHERE usuario = @nombre AND password = @password";

            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            connBuilder.Add("Database", connBuilder.Database);
            connBuilder.Add("Data Source", connBuilder.Server);
            connBuilder.Add("User Id", connBuilder.UserID);
            connBuilder.Add("Password", connBuilder.Password);

            using (MySqlConnection conn = new MySqlConnection(connBuilder.ConnectionString))
            {
                conn.Open();

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@nombre", usuario);
                command.Parameters.AddWithValue("@password", Seguridad.CodificarPassword(string.Concat(usuario, password)));
                password = null;
                MySqlDataReader reader = command.ExecuteReader();
                int count = -1;
                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                reader.Close();
                conn.Close();

                if (count <= 0)
                    return false;
                else
                    return true;

            }
        }

        public static Usuario Insert(string nombre, string apellido1, string apellido2, string email, string nombreLogin, string password)
        {
            Usuario usuario = null;

            try
            {
                usuario = new Usuario(nombreLogin, password);
                usuario.Nombre = nombre;
                usuario.Apellido1 = apellido1;
                usuario.Apellido2 = apellido2;
                usuario.Email = email;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return Insert(usuario);
        }

        public static Usuario Insert(Usuario usuario)
        {
            string sql = @"INSERT INTO usuario (
                                   nombre
                                  ,apellido1
                                  ,apellido2
                                  ,email
                                  ,usuario
                                  ,password
                                  ,idrol)
                              VALUES (
                                    @Nombre, 
                                    @Apellido1,
                                    @Apellido2,
                                    @Email,
                                    @NombreLogin,
                                    @Password,
                                    '3')"; //IdRol por defecto: nivel usuario.

            MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            connBuilder.Add("Database", connBuilder.Database);
            connBuilder.Add("Data Source", connBuilder.Server);
            connBuilder.Add("User Id", connBuilder.UserID);
            connBuilder.Add("Password", connBuilder.Password);

            using (MySqlConnection conn = new MySqlConnection(connBuilder.ConnectionString))
            {

                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("Nombre", usuario.Nombre);
                command.Parameters.AddWithValue("Apellido1", usuario.Apellido1);
                command.Parameters.AddWithValue("Apellido2", usuario.Apellido2);
                command.Parameters.AddWithValue("Email", usuario.Email);
                command.Parameters.AddWithValue("NombreLogin", usuario.NombreLogin);

                string password = Seguridad.CodificarPassword(string.Concat(usuario.NombreLogin, usuario.Password));
                command.Parameters.AddWithValue("Password", password);

                conn.Open();

                try
                {
                    command.ExecuteNonQuery();
                    long id = command.LastInsertedId;
                    usuario.Id = Convert.ToInt32(id);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return usuario;
            }
        }

    }
}
