# Procesos suspendidos

## Requerimientos

1. Cumplir con todos los requerimientos del programa anterior (actividad 14)

1. Las teclas a utilizar son:

| **Tecla** | **¿Qué indica?**                        | **¿Qué hace?**                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| :-------: | --------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
|     E     | Interrupción (pasa a estado bloqueado)  | El proceso que está en uso del procesador (ejecución) debe salir de este y esperar a que se lleve a cabo la solicitud realizada para luego poder continuar con su ejecución (planificador a corto plazo). Para este programa si se presiona “E” el proceso en ejecución saldrá del procesador y se irá a la cola de Bloqueados, permaneciendo allí un tiempo de 7, al terminar este tiempo el proceso pasará a la cola de listos a esperar su turno a usar el procesador |
|     W     | Error                                   | El proceso que se esté ejecutando en ese momento terminara por error, es decir saldrá del procesador y se mostrara en terminados, para este caso como el proceso no termino normalmente se desplegara error en lugar de un resultado. (Recuerde que al terminar un proceso queda un espacio en memoria que puede ser ocupado al admitir un proceso nuevo)                                                                                                                |
|     P     | Pausa                                   | Detiene la ejecución de su programa momentáneamente, la simulación se reanuda cuando se presione la tecla “C”.                                                                                                                                                                                                                                                                                                                                                           |
|     C     | Continuar                               | Al presionar esta tecla se reanudará el programa pausado previamente con “P”.                                                                                                                                                                                                                                                                                                                                                                                            |
|     N     | Nuevo                                   | Al presionar esta tecla se generará un nuevo proceso, creando con ello los datos necesarios de forma aleatoria. El planificador a largo plazo es el que definirá su ingreso al sistema (recordar el máximo de procesos en memoria)                                                                                                                                                                                                                                       |
|     B     | Tabla de procesos (BCP de cada proceso) | Al presionar esta tecla el programa se pausara y se deberá visualizar la tabla de procesos, es decir los BCP de cada uno de los procesos. Con la tecla “C” continua la simulación de su programa en el punto donde quedó.                                                                                                                                                                                                                                                |
|     T     | Tabla de Páginas                        | Al presionar esta tecla se detendrá la ejecución y se mostrará la tabla de páginas de cada proceso, además de los marcos libres. Continuará al presionar la tecla “C”                                                                                                                                                                                                                                                                                                    |
|     S     | Suspendido                              | Al presionar esta tecla el primero en la cola de bloqueados saldrá de memoria principal e ira a estado suspendido, es decir a disco. Debe generar un archivo con los datos de los procesos suspendidos. Si no hay procesos bloqueados no aplica.                                                                                                                                                                                                                         |
|     R     | Regresa                                 | Si presiona esta tecla el primero en la cola de suspendidos regresara a memoria principal siempre y cuando haya espacio. Si no hay procesos suspendidos no aplica.                                                                                                                                                                                                                                                                                                       |

3. Se deberá desplegar el número de procesos en estado Suspendido. Del proceso que esta por regresar a memoria, deberá mostrarse su ID y su tamaño, para así visualizar cuantos marcos libres se necesitarán.

4. El programa terminará cuando todos los procesos hayan finalizado
