# Programa 3. Algoritmo de planificación FCFS (First Come First Server)

## Requerimientos:

1. Continuamos con la práctica anterior, donde el algoritmo a utilizar en la cola de listos es FCFS.

2. Se cumplirá con todos los requisitos de la actividad 6 (programa 3)

3. A las teclas que ya estaban se agregan nuevas a utilizar, las cuales son:


| **Tecla** | **¿Qué indica?**                                          | **¿Qué hace?**                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
|-----------|-----------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| E         | Interrupción por entrada salida (pasa a estado bloqueado) | El proceso que está en uso del procesador (ejecución) debe salir de este y esperar a que se lleve a cabo la solicitud realizada para luego poder continuar con su ejecución (planificador a corto plazo). Para este programa si se presiona “E” el proceso en ejecución saldrá del procesador y se irá a la cola de Bloqueados, permaneciendo allí un tiempo de 7, al terminar este tiempo el proceso pasará a la cola de listos a esperar su turno a usar el procesador |
| W         | Error                                                     | El proceso que se esté ejecutando en ese momento terminara por error, es decir saldrá del procesador y se mostrara en terminados, para este caso como el proceso no termino normalmente se desplegara error en lugar de un resultado. (Recuerde que al terminar un proceso queda un espacio en memoria que puede ser ocupado al admitir un proceso nuevo)                                                                                                                |
| P         | Pausa                                                     | Detiene la ejecución de su programa momentáneamente, la simulación se reanuda cuando se presione la tecla “C”.                                                                                                                                                                                                                                                                                                                                                           |
| C         | Continuar                                                 | Al presionar esta tecla se reanudará el programa pausado previamente con “P”.                                                                                                                                                                                                                                                                                                                                                                                            |
| N         | Nuevo                                                     | Al presionar esta tecla se generará un nuevo proceso, creando con ello los datos necesarios de forma aleatoria. El planificador a largo plazo es el que definirá su ingreso al sistema (recordar el máximo de procesos en memoria)                                                                                                                                                                                                                                       |
| B         | Tabla de procesos (BCP de  cada proceso)                  | Al presionar esta tecla el programa se pausara y se deberá visualizar la tabla de procesos, es decir los BCP de cada uno de los procesos. Con la tecla “C” continua la simulación de su programa en el punto donde quedó.                                                                                                                                                                                                                                                |

4. Los datos a mostrar en la tabla de procesos (cuando se presiona la tecla B) son:

   a. Identificador del proceso.
   
   b. Estado del proceso. En este punto debe considerar lo siguiente: si el proceso es nuevo, los campos siguientes serán nulos, si el proceso es terminado debe señalar si fue terminado por error o normalmente, si el proceso es bloqueado hay que mostrar el tiempo restante en dicho estado.
   
   c. Operación y datos, si el proceso es terminado también mostrar resultado.
   
   d. Tiempo de Llegada.
   
   e. Tiempo de Finalización. (Si aplica)
   
   f. Tiempo de Retorno. (Si aplica)
   
   g. Tiempo de Espera. (Al momento)
   
   h. Tiempo de Servicio. (Al momento)
   
   i. Tiempo Restante en CPU. (Si aún no termina)
   
   j. Tiempo de Respuesta. (Si aplica)
   
5. Deberá mostrarse en pantalla:

   a. Listar número de procesos en estado Nuevo, actualizar ya sea porque pasan a Listos o bien por que ingresan nuevos (tecla “N”).
   
   b. Cola de listos:
      
      - Identificador de Proceso.
      
      - Tiempo Máximo Estimado.
      
      - Tiempo Restante.
      
   c. Proceso en Ejecución:
   
      - Se mostraran todos los datos correspondientes al proceso.
   
      - Tiempo transcurrido en ejecución.
   
      - Tiempo restante por ejecutar.
      
   d. Cola de Bloqueados
      
      - Identificador de Proceso.
      
      - Tiempo transcurrido en bloqueado.
   
   e. Procesos Terminados
   
      - Identificador de Proceso.
      
      - Operación.
      
      - Resultado de la operación o bien ERROR cuando el proceso haya sido terminado con la tecla “W”.
   
   f. Reloj, es decir, el contador del tiempo total transcurrido desde el inicio de la simulación hasta su término.
   
6. El programa terminará cuando todos los procesos se hayan ejecutado (pausar la pantalla al terminar para observar).

7. Mostrar al finalizar todos los datos de cada proceso, es decir, la tabla de procesos.
