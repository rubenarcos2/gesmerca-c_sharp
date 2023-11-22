/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using GesMerCa.Objs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GesMerCa.Utils
{
    class CargaInicio
    {
        public static bool comprobarConexionBD(System.Windows.Forms.Label lblCargando, System.Windows.Forms.Timer temporizador)
        {
            bool conectado = false;
            bool reintentar = false;
            int intentosFallidos = 0;

            do
            {
                try
                {
                    conectado = Utils.ConexionBD.comprobarConexionBD();
                }
                catch (Exception ex)
                {
                    Inicio.log.Registro.Error("Comprobación conexión BD. Excepción producida. ", ex);
                }
                if (conectado)
                {
                    Inicio.log.Registro.Info("Comprobación conexión BD. OK");
                    lblCargando.Text += " OK";
                }
                else
                {
                    lblCargando.Text += " " + Properties.Resources.msgCargaInicioFallida + " (" + ++intentosFallidos + ")";
                    temporizador.Stop();
                    if (MessageBox.Show(Properties.Resources.msgCargaInicioErrorBD, Properties.Resources.msgCargaInicioErrorBDTitulo, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        reintentar = true;
                    }
                    else
                        reintentar = false;
                    temporizador.Start();
                }
            } while (!conectado && reintentar);
            return conectado;
        }

        public static bool comprobarAccesoInternet(System.Windows.Forms.Label lblCargando, System.Windows.Forms.Timer temporizador)
        {
            bool conectado = false;
            bool reintentar = false;

            do
            {
                try
                {
                    System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                    Inicio.log.Registro.Info("Comprobación conexión internet. OK");
                    lblCargando.Text += " OK";
                    conectado = true;
                }
                catch (Exception ex)
                {
                    Inicio.log.Registro.Error("Comprobación conexión internet. Fallida ", ex);
                    lblCargando.Text += " " + Properties.Resources.msgCargaInicioFallida;
                    temporizador.Stop();
                    Console.WriteLine(ex.ToString());
                    if (MessageBox.Show(Properties.Resources.msgCargaInicioErrorInternet, Properties.Resources.msgCargaInicioErrorBDTitulo, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        reintentar = true;

                    }
                    else
                        reintentar = false;
                    temporizador.Start();
                }
            } while (!conectado && reintentar);
            return conectado;
        }

        public static bool cargarOpcionesGenerales(System.Windows.Forms.Label lblCargando, System.Windows.Forms.Timer temporizador)
        {
            bool conectado = false;
            try
            {
                Utilidades.opcsGen = new OpcsGen(ConexionBD.consultarRegistroBD("SELECT nombre, valor FROM config;"));
                Inicio.log.Registro.Info("Carga de las opciones generales. OK");
                conectado = true;
            }
            catch (Exception ex)
            {
                Inicio.log.Registro.Error("Carga de las opciones generales. Fallida ", ex);
                lblCargando.Text += " " + Properties.Resources.msgCargaInicioFallida;
                temporizador.Stop();
                Console.WriteLine(ex.ToString());
            }
            return conectado;
        }
    }
}
