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
using System.Drawing.Imaging;
using System.IO;

namespace GesMerCa.Utils
{
    public static class ConexionBD
    {
        private static MySqlConnection conexionBD = null;
        private static MySqlDataAdapter adaptadorBD = null;

        public static bool comprobarConexionBD()
        {
            bool conectado = false;
            try
            {
                conectarBD();
                if (conexionBD.State == System.Data.ConnectionState.Open)
                {
                    conectado = true;
                    desconectarBD();
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            return conectado;
        }

        private static void conectarBD()
        {
            try
            {
                if (conexionBD != null)
                    conexionBD.Close();

                MySqlConnectionStringBuilder connBuilder = new MySqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
                connBuilder.Add("Database", connBuilder.Database);
                connBuilder.Add("Data Source", connBuilder.Server);
                connBuilder.Add("User Id", connBuilder.UserID);
                connBuilder.Add("Password", connBuilder.Password);

                conexionBD = new MySqlConnection(connBuilder.ConnectionString);
                conexionBD.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        private static void desconectarBD()
        {
            try
            {
                conexionBD.Close();
                conexionBD = null;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public static MySqlDataAdapter getAdapterBD(string sql)
        {
            try
            {
                conectarBD();
                if (adaptadorBD == null)
                {
                    adaptadorBD = new MySqlDataAdapter(sql, conexionBD);
                }
                desconectarBD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return adaptadorBD;
        }

        public static List<string[]> consultarRegistroBD(string sql)
        {
            List<string[]> resultadoSQL = null;
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = cmd.ExecuteReader();
                resultadoSQL = new List<string[]>();
                while (reader.Read())
                {
                    string[] fila = new string[reader.VisibleFieldCount];
                    for (int i = 0; i < fila.Length; i++)
                    {
                        if (!reader.IsDBNull(i))
                            fila[i] = reader.GetString(i);
                        else
                            fila[i] = null;
                    }
                    resultadoSQL.Add(fila);
                }
                reader.Close();
                desconectarBD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultadoSQL;
        }

        public static Image consultarImagenBD(string sql)
        {
            Image img = null;
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                byte[] imgArr = (byte[])cmd.ExecuteScalar();
                imgArr = (byte[])cmd.ExecuteScalar();
                using (var stream = new MemoryStream(imgArr))
                {
                    img = Image.FromStream(stream);
                }
                desconectarBD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return img;
        }

        public static List<Object[]> consultarImagenesLoginFacial(string sql)
        {
            List<Object[]> listaImagenUsuario = new List<object[]>();
            try
            {
                conectarBD();
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                MySqlDataReader reader = cmd.ExecuteReader();

                byte[] Binary = null;
                const int ChunkSize = 100;
                int SizeToWrite = 0;
                MemoryStream MStream = null;
                Image img = null;
                while (reader.Read())
                {
                    Binary = (reader["imagen"]) as byte[];
                    SizeToWrite = ChunkSize;
                    MStream = new MemoryStream(Binary);

                    for (int i = 0; i < Binary.GetUpperBound(0) - 1; i = i + ChunkSize)
                    {
                        if (i + ChunkSize >= Binary.Length) SizeToWrite = Binary.Length - i;
                        byte[] Chunk = new byte[SizeToWrite];
                        MStream.Read(Chunk, 0, SizeToWrite);
                        img = Image.FromStream(MStream);
                    }

                    listaImagenUsuario.Add(new Object[] { img, reader.GetString("usuario") });
                }
                reader.Close();
                desconectarBD();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listaImagenUsuario;
        }

        public static int insertarRegistroBD(string sql)
        {
            int registrosAfectados = -1;
            conectarBD();
            MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
            registrosAfectados = cmd.ExecuteNonQuery();
            desconectarBD();
            return registrosAfectados;
        }

        public static int modificarRegistroBD(string sql)
        {
            int registrosAfectados = -1;
            conectarBD();
            MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
            registrosAfectados = cmd.ExecuteNonQuery();
            desconectarBD();
            return registrosAfectados;
        }

        public static int insertarImagenBD(string sql, Image img, ImageFormat extension)
        {
            int registrosAfectados = -1;
            conectarBD();
            MemoryStream ms = new MemoryStream();
            img.Save(ms, extension);
            byte[] pic_arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(pic_arr, 0, pic_arr.Length);
            MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
            cmd.Parameters.AddWithValue("@imagen", pic_arr);
            registrosAfectados = cmd.ExecuteNonQuery();
            desconectarBD();
            return registrosAfectados;
        }
    }
}
