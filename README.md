# Interfaces Inteligentes
## Práctica 2. Introducción C#, Scripts
### Alumna: Nailea Fayna Cruz Galván (alu0101477497)

**Descripción:**
En esta práctica se ha propuesto realizar una serie de tareas básicas con el objetivo de aprender C#. En este fichero, explicaré dichas tareas y cómo las llevé a cabo.

### Desarrollo de tareas
---

**1. Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.**

Creé un script llamado ChangeColor y lo asocié a un cubo (Llamado ColorCube).
El script inicializa un vector con tres valores gracias a `Random.value`, que devuelve valores entre 0.0 y 1.0 (perfecto para el RGB).
Cada 120 frames (se puede cambiar desde el inspector), se cambia aleatoriamente uno de los tres canales del color y se asigna el nuevo color al material del objeto gracias `material.color`. La elección de cambiar únicamente 1 canal hace que el cambio de colores no sea tan drástico, sino que siempre cambiará a un color parecido al anterior.

![CubeColor](img/cubecolor.gif)

**2. Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola: La magnitud de cada uno de ellos, el ángulo que forman, la distancia entre ambos, un mensaje indicando qué vector está a una altura mayor y muestra en el inspector cada uno de esos valores.**

Asocié un script llamado VectorInspector a la esfera, con dos variables públicas Vector3 para poder asignar sus componentes desde el inspector.
El script muestra en la consola lo que se pide en el enunciado al empezar el programa (Más adelante se incluye el pantallazo).

![SphereVector](img/spherevector.png)

**3. Muestra en pantalla el vector con la posición de la esfera.**

En este caso creé un script llamado ShowPosition que muestra en consola el vector con la posición de la esfera al empezar el juego. Para esto usé la propiedad `transform.position` del componente Transform del GameObject para obtener su posición.

**4. Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.**

Para lograrlo cree un script llamado DistanceToObjects asociado a la esfera. El script busca los objetos Cubo y Cilindro mediante sus etiquetas (FindWithTag) y obtiene sus componentes Transform. Las etiquetas son ColoredCube (para el cubo) y simplemente Cylinder (para el cilindro). Gracias a utilizar `Vector3.Distance()` podemos calcular la distancia entre las posiciones.

-> Consola tras la ejecución de las tareas 2, 3 y 4:

![PrintInfo](img/printinfo.png)

El motivo por el que escogí imprimirlo únicamente con Start() y no con Update() es porque según avanzamos hay más ejercicios que requieren de imprimir por consola y sí que utilizan el Update(), así que para facilitar la lectura del output únicamente dejé lo necesario en Update().

**5. Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora. Estos vectores representan un desplazamiento respecto a la posición original de cada objeto. Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.**

En este apartado añadí un objeto vacío llamado "Marker" que almacena tres vectores públicos con las posiciones de desplazamiento configurables desde el inspector. Cada objeto (cubo, cilindro y esfera) tiene una variable pública de desplazamiento para definir cuánto se moverá respecto a su posición inicial.

El script creado fue MoveOnSpace que detecta la cuando pulsamos la barra espaciadora usando Input.GetAxis("Jump"). Al pulsarla, los objetos se reubican sumando su desplazamiento a la posición que está definida en el marcador.

![Space](img/space.gif)

