# Trabajo Practico 1 - Grupo 4

## Integrantes:
* Bossio Alberto Federico
* Fornes Ezequiel Christian
* Mandirola Gabriel Nicolas
* Ramos Lautaro Agustin
* Toyama Rodrigo
* Zarate Miranda Saul Denis


## Ejercicio 1: Agencia de Viajes

En este ejercicio puede realizarse una carga de datos en un array (con un usuario administrador) o ver los datos del mismo (con un usuario cliente).
Al iniciar el programa se ejecuta la clase app (esta clase fue creada para contener los datos de inicio, visualización, usuarios y para mantener limpia la clase principal) la cual nos pedirá que seleccionemos el tipo de usuario que somos y luego nos pedirá que ingresemos los datos del usuario.
Dependiendo el tipo de usuario con el que hayamos ingresado apareceran las opciones correspondientes:

* Si ingresé con un usuario administrador podré agregar un nuevo alojamiento de tipo cabaña o de tipo hotel. En el caso de ser de tipo cabaña podré agregar los datos de alojamiento (codigo, ciudad, barrio, estrellas, cantidadDePersonas y tv) y además los datos de tipo cabaña (precioPorDia, cantidadDeHabitaciones, cantidadDeBanios), estos datos se guardaran en el array de alojamientos el cual se encuentra en la clase Agencia y en el caso de ser de tipo hotel podré agregar los datos de alojamiento (codigo, ciudad, barrio, estrellas, cantidadDePersonas y tv) y además los datos de tipo hotel (precioPorPersona), estos datos se guardaran en el array de alojamientos el cual se encuentra en la clase Agencia. A continuación el programa revisará que no haya un duplicado de código (entero de la clase Alojamiento) dentro del array y en caso de ser así aparecerá un mensaje confirmando el ingreso de datos en el array. Cuando haya finalizado el proceso se cerrará la sesión y podrá volver a iniciar sesión con un usuario cliente o administrador.

* Si ingresé con un usuario cliente podré observar los datos ingresados previamente en el array alojamiento, para ello el programa le data tres opciones: 1- Ver todos los alojamientos de tipo hotel. 2- Ver los alojamientos con cierta cantidad de estrellas elegidas por el usuario o superior. 3- Ver los alojamientos de tipo cabaña que se encuentren en el rango de precios elegido por el usuario. Cuando haya finalizado el proceso se cerrará la sesión y podrá volver a iniciar sesión con un usuario cliente o administrador.



## Ejercicio 2: Centro Cultural
