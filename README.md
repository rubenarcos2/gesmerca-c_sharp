All content is licensed under a Creative Commons Attribution 4.0 International License
[![LiLicensee: license.markdownC BY-NC-ND 4.0](https://licensebuttons.net/l/by-nc-nd/4.0/80x15.png)](https://creativecommons.org/licenses/by-nc-nd/4.0/)

# GesMerca - Proyecto fin de ciclo (C#)

Proyecto integrado fin del Ciclo Formativo de Grado Superior de Aplicaciones Multiplataformas.

Integrated project for the Ciclo Formativo de Grado Superior de Aplicaciones Multiplataformas.

## Descripción / Description

La finalidad principal de la aplicación, ha sido la demostración de la puesta en práctica de los conocimientos  adquiridos a lo  largo  del  ciclo  formativo  de  desarrollo  de  aplicaciones multiplataforma.
He  focalizado  la  aplicación  en  los  conocimientos  adquiridos  sobre  la gestión de privilegios  de acceso  de usuarios a distintos elementos (o módulos como me referiré a lo largo del documento) de la aplicación, la gestión de usuarios jerarquizados en distintos  grupos  (denominados  roles)  y  la  administración  por  parte  de  un   usuario autorizado.
No menos relevante ha sido la aplicación de los conocimientos en el diseño y gestión de bases de datos relacionales y las plataformas de implementación de estas. Otro  factor  que  se  tenido  en  cuenta  ha  sido  la  seguridad  del  entorno  de  uso  y  de  la aplicación,   implementando   funcionalidades   como   el   bloqueo   físico   del   terminal, la encriptación de datos sensibles, o la prevención en la utilización de elementos sensibles a la inyección de información automatizada (cracking o ataques de fuerza bruta).

The main purpose of the application has been the demonstration of the implementation of the knowledge acquired throughout the training cycle of multiplatform application development.
I have focused the application on the knowledge acquired about the management of user access privileges to different elements (or modules as I will refer to throughout the document) of the application, the management of users ranked in different groups (called roles) and the administration by an authorized user.
No less relevant has been the application of knowledge in the design and management of relational databases and their implementation platforms. Another factor that has been taken into account has been the security of the environment of use and of the application, implementing features such as the physical blocking of the terminal, the encryption of sensitive data, or the prevention of the use of elements sensitive to the injection of automated information. (cracking or brute force attacks).

## Documentación / Documents

Lea toda la información disponible antes de utilizar en: [https://rarcos.com/2016/06/11/Proyecto_integrado/](https://rarcos.com/2016/06/11/Proyecto_integrado/)

Read all info before use this software: [https://rarcos.com/2016/06/11/Proyecto_integrado/](https://rarcos.com/2016/06/11/Proyecto_integrado/)

## Descarga del instalador / Installer

[https://github.com/rubenarcos2/proyecto_dam/installer](https://github.com/rubenarcos2/proyecto_dam/installer)

## Puesta en funcionamiento / Starter

La aplicación está parametrizada por defecto para la conexión a una base de datos externa alojada en internet. Es posible que presente algún tipo de retraso o sobrecarga ajena a la aplicación por disponibilidad del servicio, se ruega, si presenta algún mensaje informativo de falta de conexión se reintente pasado un tiempo o se realice la instalación local con el fichero [GesMerCa_Backup.sql](https://github.com/rubenarcos2/proyecto_dam/GesMerCa_Backup.sql). Una vez instalada la base de datos cambie la contraseña de esta en el fichero de configuración [app.config](https://github.com/rubenarcos2/proyecto_dam/app.config).

The application is parameterised by default for connection to an external database hosted on the internet. It is possible that it may present some kind of delay or overload external to the application due to the availability of the service, please, if it presents some informative message of lack of connection, try again after some time or perform the local installation with the file [GesMerCa_Backup.sql](https://github.com/rubenarcos2/proyecto_dam/GesMerCa_Backup.sql). Once the database is installed, change the database password in the configuration file [app.config](https://github.com/rubenarcos2/proyecto_dam/app.config).

### Licencia / License

[License about details](https://github.com/rubenarcos2/proyecto_dam/blob/master/license.md)
