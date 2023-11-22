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
    class Proveedor
    {
        public int CifNif { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
    }
}
