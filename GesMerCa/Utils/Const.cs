/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

namespace GesMerCa.Utils
{
    public static class Const
    {
        #region Carga inicial

        public const int NUM_PROCESOS_CARGA = 3;

        #endregion

        #region Pantalla Bloque

        public const int TIEMPO_BLOQUEO_TERMINAL = 300; //seg
        #endregion

        #region Login

        //Modo de acceso de Login Uss/Pass
        public enum LOGIN_MODO_IDENTIFICACION { USS_PASS, FACIAL, TARJETA };

        //Modo de acceso de Login detección facial
        public enum LOGINFACIAL_MODO_ACCESO{ Reconocimiento, Entrenamiento };

        //Requerimiento de contraseña además del Uss en Login
        public const bool REQUIERE_PASSWORD= true;

        #endregion

        #region Seguridad

        public enum NIVEL_PASSWORD
        {
            Vacía = 0,
            Insuficiente = 1,
            Débil = 2,
            Aceptable = 3,
            Compleja = 4,
            Fuerte = 5
        }

        #endregion

        #region Opciones de configuración

        //Modo de acceso de Login Uss/Pass
        public enum TIPO_OPCION_CONFIG { GENERAL, USUARIO };

        #endregion
    }
}
