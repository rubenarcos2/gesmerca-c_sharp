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
    class OpcsGen
    {
        private Dictionary<string, string> listaOpciones;

        public OpcsGen(List<string[]> opcionesBD)
        {
            listaOpciones = new Dictionary<string, string>();
            foreach(string[] opcion in opcionesBD)
            {
                listaOpciones.Add(opcion[0], opcion[1]);
            }
        }

        public string getValorClave(string clave)
        {
            string valor = null;

            if (listaOpciones.TryGetValue(clave, out valor))
            {
                Inicio.log.Registro.Info("Se ha solicitado el valor de la opción: " + clave + " = " + valor);
            }
            else
            {
                Inicio.log.Registro.Warn("Se ha solicitado el valor de la opción: " + clave + ", no existe la opción");
            }
            return valor;
        }
    }
}
