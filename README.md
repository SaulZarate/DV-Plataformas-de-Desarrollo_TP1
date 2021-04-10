# Trabajo Practico 1 - Grupo 4


## Ejercicio 1: Agencia de Viajes 🚀

_En este ejercicio puede realizarse una carga de datos en un array (con un usuario administrador) o ver los datos del mismo (con un usuario cliente).
Al iniciar el programa se ejecuta la clase app (esta clase fue creada para contener los datos de inicio, visualización, usuarios y para mantener limpia la clase principal) la cual nos pedirá que seleccionemos el tipo de usuario que somos y luego nos pedirá que ingresemos los datos del usuario.
Dependiendo el tipo de usuario con el que hayamos ingresado apareceran las opciones correspondientes:_

* Si ingresa como administrador, el programa te preguntara si deseas iniciar sesion, en cuyo caso te pedira las credenciales necesarias (usuario/contraseña). Una ves iniciada la sesion podras agregar un nuevo alojamiento de tipo cabaña o de tipo hotel. 
  * _En el caso de ser de tipo cabaña podré agregar los datos del alojamiento (codigo, ciudad, barrio, estrellas, cantidadDePersonas y tv) y además los datos de tipo cabaña (precioPorDia, cantidadDeHabitaciones, cantidadDeBanios), estos datos se guardaran en el array de alojamientos el cual se encuentra en la clase Agencia_
  * _En el caso de ser de tipo hotel podras agregar los datos del alojamiento (codigo, ciudad, barrio, estrellas, cantidadDePersonas y tv) y además los datos de tipo hotel (precioPorPersona), estos datos se guardaran en el array de alojamientos el cual se encuentra en la clase Agencia_
  * A continuación el programa revisará que no haya un duplicado de código (entero de la clase Alojamiento) dentro del array y en caso de ser así aparecerá un mensaje confirmando el ingreso de datos en el array. Cuando haya finalizado el proceso se le volvera apreguntar si desea agregar un alojamiento nuevo o si desea cerrará la sesión.

* Si ingresa como cliente, ingresaras al Menu de la Agencia y podras observar los datos ingresados previamente en el array alojamiento, para ello el programa le dara tres opciones principales y dependiendo la que selecciones se te abrira un sub menu para preguntar si quiere verlas por un orden o filtro en particular. Todos los submenus tienen las opciones de llevarte al Menu de la Agencia o terminar el programa  
  * 1- Ver todos los hoteles 
  * 2- Ver todas las cabañas 
  * 3- Ver todos los alojamientos


## Ejercicio 2: Centro Cultural 📖

* En este ejercicio se desarrolla un centro cultural, se pueden ingresar artistas, obras y elegir las obras y los artistas en exposicion. 
Se pueden ingresar los datos de los artistas: nombre, nacionalidad, fecha de nacimiento y fecha de fallecimiento, en la clase artistasExposicion esta la funcionalidad de agregar artistas a la exposicion, tiene el control de agregar los artistas y las obras la clase Centro Cultural, ya que es la que toma las decisiones sobre las exposiciones, ademas se puede consultar lo siguiente: la cantidad de artistas, si el artista de dicha obra esta ingresado o no, si la expo esta llena, si hay artistas, recuperar una artista segun el nombre, recuperar artistas segun su nacionalidad.

* Las obras se administran de la siguiente manera, esta la clase ObrasExposicion donde se exponen las obras, la clase obra que es un clase generica heredada por la clase cuadro y la clase escultura, la clase obra tiene los siguientes datos de las obras: código, nombre, nombre artista, fecha de cración, fecha de ingreso (Las fechas piden un tipo DateTime para no tener que hacer una clase nueva). La clase cuadro hereda a obra y pide ademas la altura y la base del cuadro, ademas hay una clase llamada cuadro prestado donde se ingresan los cuadros que tenemos pero que pertenecen a otra galeria, esta clase pide fecha de devolucion y el nombre de la galeria. La clase escultura hereda a obra y pide peso y volumen.

## Integrantes ✒️

* **Bossio Alberto Federico** - *Desarrollador*
* **Fornes Ezequiel Christian** - *Desarrollador*
* **Mandirola Gabriel Nicolas** - *Desarrollador*
* **Ramos Lautaro Agustin** - *Desarrollador*
* **Toyama Rodrigo** - *Desarrollador*
* **Zarate Miranda Saul Denis** - *Desarrollador*
