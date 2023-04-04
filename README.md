# VM-Software

VM Software, o Video Club Manager Software es un sistema CRUD que le permite a un negocio de Video Club controlar su inventario. Este proyecto fue realizado como un trabajo escolar que planteaba conectar una aplicación de escritorio a una base de datos de MySql. Dicha aplicación de escritorio fue creada en base a C#, .NET Framework 4.7.2 y Windows Forms.

# ¿Cómo instalar este programa para verlo en funcionamiento?
## Descargar carpeta Release

La carpeta realese contiene el ejecutable "proyecto Topicos.exe" junto a todos los recursos que necesita la aplicación para funcionar, bastará con ejecutar el .exe. Sin embargo, hay que considerar que el proyecto fue realizado con .NET Framework 4.7.2 y se necesita esta misma para que pueda funcionar. Además, es necesario correr una instancia de MySQL con la base de datos adjunta importada y funcionando para poder acceder a todas las funciones del programa.

## Descargar y poner en funcionamiento la base de datos
En el repositorio se puede ver el archivo "vmsoftware.sql", esta es la base de datos MySql usada para el proyecto. Es recomendable usar Apache y MySql con phpMyAdmin para importar y hostear localmente esta base de datos. De esta manera, se podrá usar integramente el programa.

# Uso del programa
Una vez se haya compeletado la instalación, se puede ejecutar "proyecto Topicos.exe" dentro de la carpeta Release y se procederá a abrir la aplicación con la siguiente pantalla:

<p align="center">
  <img src="/ImagenesReadme/Principal.png" alt="Pantalla principal">
</p>

Para interactuar con la base de datos y empezar a ingresar, editar, consultar y eliminar datos, es necesario dirigirse al menú lateral izquierdo y seleccionar una sección. Después de esto, se podrá observar una pantalla como la siguiente:

<p align="center">
  <img src="/ImagenesReadme/Registros.png" alt="Pantalla génerica de CRUD">
</p>

Esta pantalla es génerica y funciona para todas las secciones respectivamente. Con el botón de "Agregar registro" se puede hacer un alta de un registro a la base de datos, apareciendo un formulario tan pronto se de click en él. 

Para bajas y modificaciones es necesario usar el menú desplegable que se puede ver arriba a la derecha, se selecciona el ID del registro que se quiera eliminar y se selecciona una de las opciones de "Modificar" o "Eliminar". la opcion de Modificar volverá a abrir el formulario con los datos del registro precargados. Por otro lado, la opción de Eliminar simplemente dará de baja el registro de la base de datos.

Finalmente, para realizar una consulta, sencillamente se da click al botón con el simbolo de recargar arriba a la derecha, y los registros actualizados deberían aparecer en el Grid del centro.

Cabe resaltar que cada sección en el menú lateral corresponde a una tabla de la base de datos, y para modificar algunas de ellas es necesario ingresar registros a otras antes.

# Cambios que realizaría a este proyecto
Este proyecto fue realizado en abril de 2022, y desde entonces he adquirido más experiencia en el desarrollo de software. Algunos cambios que haría a este proyecto son:
- Cambiar el diseño de la base de datos: La base de datos no está bien normalizada y tiene detalles que dificultan las consultas, o que son irrelevantes a nivel de base de datos y hoy cambiaría.
- Agregar un login y cambiar la base de datos para contener usuarios y distintos tipos de usuario, que a su vez solo podrían acceder a determinadas pantallas dentro de la aplicación.
- No incluiría la opción de dar de baja un registro: Esta práctica trae problemas al momento de querer hacer reportes de productos que ya no se encuentran en circulación. Un cassette dado de baja ya no podría figurar en los registros de la tabla de prestamos, por ejemplo, y por lo tanto no sería consultable. Por otro lado, las tablas tendrían campos referentes a el estado actual del registro. Por ejemplo, un cassette podría cambiar de estado para ya no poder ser utilizado en futuros prestamos, pero los prestamos donde estuvo involucrado en el pasado seguirían siendo consultables.
- Agregar una bitácora de los movimientos realizados en el sistema.

# Autoría
Este proyecto fue realizado por Jose Julian Hernandez Jara.
Username de Github: JulyAn1234
Link de perfil: https://github.com/JulyAn1234
