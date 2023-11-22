/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace GesMerCa.Utils
{
    public static class Seguridad
    {
        public static void ProtectConnectionString()
        {
            ToggleConnectionStringProtection
        (System.Windows.Forms.Application.ExecutablePath, true);
        }

        public static void UnprotectConnectionString()
        {
            ToggleConnectionStringProtection
        (System.Windows.Forms.Application.ExecutablePath, false);
        }

        private static void ToggleConnectionStringProtection
                (string pathName, bool protect)
        {
            string strProvider = "DataProtectionConfigurationProvider";

            System.Configuration.Configuration oConfiguration = null;
            System.Configuration.ConnectionStringsSection oSection = null;

            try
            {
                oConfiguration = System.Configuration.ConfigurationManager.
                                                OpenExeConfiguration(pathName);

                if (oConfiguration != null)
                {
                    bool blnChanged = false;

                    oSection = oConfiguration.GetSection("connectionString") as
                System.Configuration.ConnectionStringsSection;

                    if (oSection != null)
                    {
                        if ((!(oSection.ElementInformation.IsLocked)) &&
                (!(oSection.SectionInformation.IsLocked)))
                        {
                            if (protect)
                            {
                                if (!(oSection.SectionInformation.IsProtected))
                                {
                                    blnChanged = true;

                                    oSection.SectionInformation.ProtectSection
                                (strProvider);
                                }
                            }
                            else
                            {
                                if (oSection.SectionInformation.IsProtected)
                                {
                                    blnChanged = true;

                                    oSection.SectionInformation.UnprotectSection();
                                }
                            }
                        }

                        if (blnChanged)
                        {
                            oSection.SectionInformation.ForceSave = true;

                            oConfiguration.Save();
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                throw (ex);
            }
        }

        public static string CodificarPassword(string originalPassword)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(originalPassword);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }

        public static Utils.Const.NIVEL_PASSWORD comprobarNivelPassword(string password)
        {
            int puntuacion = 0;

            if (string.IsNullOrEmpty(password))
            {
                return Utils.Const.NIVEL_PASSWORD.Vacía;
            }

            if (password.Length < 1)
            {
                return Utils.Const.NIVEL_PASSWORD.Vacía;
            }

            if (password.Length < 4)
            {
                return Utils.Const.NIVEL_PASSWORD.Insuficiente;
            }

            if (password.Length >= 8)
            {
                puntuacion++;
            }

            if (password.Length >= 10)
            {
                puntuacion++;
            }

            if (Regex.Match(password, @"\d", RegexOptions.ECMAScript).Success)
            {
                puntuacion++;
            }

            if (Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success &&
                Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success)
            {
                puntuacion++;
            }

            if (Regex.Match(password, @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,),€]", RegexOptions.ECMAScript).Success)
            {
                puntuacion++;
            }

            return (Utils.Const.NIVEL_PASSWORD)puntuacion;
        }
    }
}
