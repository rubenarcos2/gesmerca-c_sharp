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
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Text;

namespace GesMerCa.Utils
{
    class Utilidades
    {
        //OPCIONES generales de la aplicación
        public static OpcsGen opcsGen;
        //USUARIO actualment logado
        public static Usuario usuarioActual;
        //PRIVILEGIOS - Módulos restringidos: por cada registro: NombreMódulo[0], PermisosLectura[1], PermisosEscritura[2]
        public static List<string[]> listaRestriccionesRolUsuario = null;

        public static List<string> listaElementosBarraHerramientas = null;
        public static List<string> listaElementosMenuSuperior = null;

        private static SpeechSynthesizer sintetizadorTTS = null;

        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool comprobarExistenciaUsuario(string nombreUsuario)
        {
            bool existe = false;
            List<string[]> listaUsarios = OperBD.consultaTodosUsuarios();
            foreach (var usuario in listaUsarios)
            {
                if (usuario[1].ToUpper().Equals(nombreUsuario.ToUpper()))
                    existe = true;
            }
            return existe;
        }

        //public static void asignarTTScontrol(Control control, string texto)
        //{
        //    textoTTS = texto;
        //    control.MouseHover += new EventHandler(ratonEncimaTTS);
        //}

        public static void activarTTS(string textoTTS)
        {
            if (Convert.ToBoolean(Utilidades.opcsGen.getValorClave("tts")))
            {
                System.Threading.Thread hilo = new System.Threading.Thread(delegate ()
                {
                    try
                    {
                        if (sintetizadorTTS == null)
                            sintetizadorTTS = new SpeechSynthesizer();
                        sintetizadorTTS.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0, System.Globalization.CultureInfo.CurrentCulture);
                        //if (Application.CurrentInputLanguage.Culture.Name.ToString().Equals("es-ES"))
                        //    sintetizadorTTS.SelectVoice("Microsoft Helena Desktop");
                        //else
                        //    sintetizadorTTS.SelectVoice("Microsoft Zira Desktop");
                        sintetizadorTTS.Volume = 100;
                        sintetizadorTTS.Rate = 0;
                        textoTTS.Replace('&', ' ');
                        sintetizadorTTS.Speak(textoTTS);
                        //sintetizadorTTS.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR en el TTS: " + ex);
                        Inicio.log.Registro.Error("ERROR en el TTS, texto: " + textoTTS, ex);
                    }
                });
                hilo.Start();
                hilo.IsBackground = true;
            }
        }

        /// <summary>
        /// Funcion que valida un CIF
        /// </summary>
        /// <param name="Numero">El numero del CIF a validar</param>
        /// <returns>True si el CIF es correcto</returns>
        public static bool Valida_CIF(string Numero)
        {
            //Valida el cif actual
            string[] letrasCodigo = { "J", "A", "B", "C", "D", "E", "F", "G", "H", "I" };

            string LetraInicial = Numero[0].ToString();
            string DigitoControl = Numero[Numero.Length - 1].ToString();
            string n = Numero.ToString().Substring(1, Numero.Length - 2);
            int sumaPares = 0;
            int sumaImpares = 0;
            int sumaTotal = 0;
            int i = 0;
            bool retVal = false;

            // Recorrido por todos los dígitos del número
            // Recorrido por todos los dígitos del número
            for (i = 0; i < n.Length; i++)
            {
                int aux;
                Int32.TryParse(n[i].ToString(), out aux);

                if ((i + 1) % 2 == 0)
                {
                    // Si es una posición par, se suman los dígitos
                    sumaPares += aux;
                }
                else
                {
                    // Si es una posición impar, se multiplican los dígitos por 2
                    aux = aux * 2;

                    // se suman los dígitos de la suma
                    sumaImpares += SumaDigitos(aux);
                }
            }

            // Se suman los resultados de los números pares e impares
            sumaTotal += sumaPares + sumaImpares;

            // Se obtiene el dígito de las unidades
            Int32 unidades = sumaTotal % 10;

            // Si las unidades son distintas de 0, se restan de 10
            if (unidades != 0) unidades = 10 - unidades;

            switch (LetraInicial)
            {
                // Sólo números
                case "A":
                case "B":
                case "E":
                case "H":
                    retVal = DigitoControl == unidades.ToString();
                    break;

                // Sólo letras
                case "K":
                case "P":
                case "Q":
                case "S":
                    retVal = DigitoControl == letrasCodigo[unidades];
                    break;

                default:
                    retVal = (DigitoControl == unidades.ToString()) || (DigitoControl == letrasCodigo[unidades]);
                    break;
            }

            return retVal;

        }

        private static Int32 SumaDigitos(Int32 digitos)
        {
            string sNumero = digitos.ToString();
            Int32 suma = 0;

            for (Int32 i = 0; i < sNumero.Length; i++)
            {
                Int32 aux;
                Int32.TryParse(sNumero[i].ToString(), out aux);
                suma += aux;
            }
            return suma;
        }
        /// <summary>
        /// Valida un NIF
        /// </summary>
        /// <param name="valor">NIF a validar</param>
        /// <returns>Resultado de la validacion</returns>
        public static Boolean VerificarNIF(String valor)
        {
            String aux = null;
            valor = valor.ToUpper();
            int numero = -1;

            // ponemos la letra en mayúscula
            aux = valor.Substring(0, valor.Length - 1);
            // quitamos la letra del NIF
            int.TryParse(aux, out numero);
            if (aux.Length >= 7 && numero > -1)
                aux = CalculaNIF(aux); // calculamos la letra del NIF para comparar con la que tenemos
            else
                return false;

            // comparamos las letras
            return (valor != aux);
        }

        /// <summary>
        /// Dado un DNI obtiene la letra que le corresponde al NIF
        /// </summary>
        /// <param name="strA">DNI</param>
        /// <returns>Letra del NIF</returns>
        private static String CalculaNIF(String strA)
        {
            const String cCADENA = "TRWAGMYFPDXBNJZSQVHLCKE";
            const String cNUMEROS = "0123456789";

            Int32 a = 0;
            Int32 b = 0;
            Int32 c = 0;
            Int32 NIF = 0;
            StringBuilder sb = new StringBuilder();

            strA = strA.Trim();
            if (strA.Length == 0) return "";

            // Dejar sólo los números
            for (int i = 0; i <= strA.Length - 1; i++)
                if (cNUMEROS.IndexOf(strA[i]) > -1) sb.Append(strA[i]);

            strA = sb.ToString();
            a = 0;
            NIF = Convert.ToInt32(strA);
            do
            {
                b = Convert.ToInt32((NIF / 24));
                c = NIF - (24 * b);
                a = a + c;
                NIF = b;
            } while (b != 0);

            b = Convert.ToInt32((a / 23));
            c = a - (23 * b);
            return strA.ToString() + cCADENA.Substring(c, 1);
        }
    }
}
