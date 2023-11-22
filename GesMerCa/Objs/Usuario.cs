/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GesMerCa.Objs
{
    class Usuario
    {
        public Usuario(string nombreLogin, string password)
        {
            Id = -1;
            Apellido1 = null;
            Apellido2 = null;
            Email = null;
            if(String.IsNullOrEmpty(nombreLogin) || String.IsNullOrEmpty(password))
            {
                throw new System.ArgumentException(Properties.Resources.msgObjUssError, Properties.Resources.msgObjUssErrorTitulo);
            }else
            {
                NombreLogin = nombreLogin;
                Password = password;
            }
        }

        public Usuario(string nombreLogin, int idRol)
        {
            Id = -1;
            IdRol = idRol;
            Apellido1 = null;
            Apellido2 = null;
            Email = null;
            if (String.IsNullOrEmpty(nombreLogin) )
            {
                throw new System.ArgumentException(Properties.Resources.msgObjUssError, Properties.Resources.msgObjUssErrorTitulo);
            }
            else
            {
                NombreLogin = nombreLogin;
                Password = null;
            }
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Email { get; set; }
        public string NombreLogin { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
    }
}
