# C# con .NET Core
## Notas del [Curso de C# con .Net Core](https://platzi.com/clases/c-sharp/)

## Herencia
La herencia en la programación funciona del mismo modo que en la vida real, un padre puede dejar en herencia ciertas características y atributos a sus hijos.

Aprendamos a utilizar la herencia en nuestro código y veamos como una clase hijo puede heredar ciertas características o funciones de la clase padre, también veremos que estas funciones o métodos heredados se pueden sobrescribir.

Al momento de programar nuestras clases padre podemos usar la palabra clave `abstract` para que dicha clase solamente pueda ser heredada, pero nunca instanciada. Por el contrario, tenemos la palabra clave `sealed` permite generar instancias de la clase, pero no permite heredarla.

## Polimorfismo
En polimorfismo un objeto hijo que hereda de una clase padre puede ser tratado como un objeto padre, pero al ser convertido en objeto padre ya no se podrá acceder a los atributos del objeto hijo. Por otro lado, un objeto padre no puede tratarse como un objeto hijo a menos que el objeto padre estuviera guardando un objeto hijo.

## Problemas del polimorfismo
El polimorfismo, aunque es muy bueno, puede ocasionarnos problemas al momento de ejecutarse nuestro programa si hacemos un mal uso del casting.

- **Upcasting** Casteo implícito de una clase hija hacia su clase padre, con lo que si se tienen métodos sobrecargados en la clase hija, al hacer esto no se pueden invocar desde tu objeto ya que solo tienes disponibles los de la clase padre.
- **Downcasting** Castear explícitamente un objeto de clase padre hacia su clase hija, para poder tener acceso a los métodos de la case hija

## Lista de Objetos polimórfica
Vamos a crear un método que nos regrese todos los objetos Escuela de la escuela a través de un List de ObjetoEscuelaBase.

En C# podemos realizar validaciones sobre el tipo de objeto que estamos manejando, usando las siguientes palabras clave:

- **is**, para verificar si un objeto es de un tipo en específico.
- **as**, para tratar un objeto como un tipo específico, en caso de no poder convertir el objeto entonces va a asignar un valor null.

## Utilizando ToString para mejorar la depuración
Vamos a sobrescribir el método ToString para mejorar la depuración de nuestro proyecto. Gracias a la herencia podemos sobrescribir el método en nuestra clase padre y todas sus clases hijas también tendrán sobrescrito el método.

## Implementación de interfaces - Etapa 6
En C# no existe la herencia múltiple, sin embargo, esto no es una limitante para hacer que un objeto se vea como otros objetos diferentes ya que podemos recurrir al uso de interfaces.

Una interfaz es la definición de la estructura de un objeto. Las interfaces las podemos tomar como contratos en las que obligamos a que los objetos cumplan determinadas características.

## Uso de interfaces
Desde el punto de vista de la programación orientada a objetos cualquier objeto puede ser visto como una interfaz.

Haciendo uso de Linq vamos a seleccionar de nuestra lista de objetos todos los objetos y les haremos casting con ILugar. Si no declaramos que nos retorne sólo los objetos que sean de tipo ILugar, entonces el programa al realizar el casting va a causar errores silenciosos.

## Creación y uso de regiones
Una clase con muchas responsabilidades será un indicio de que nuestro código no está totalmente optimizado.

Las regiones no cambian a nivel de programación, pero si en la utilización del IDE. Situando código entre #region y #endregionel IDE va a ser capaz de colapsar todo ese bloque de código mejorando la legibilidad de este.

## Parámetros de salida
Los parámetros opcionales siempre deben ir al último de un método.
Un parámetro de salida se debe marcar con la palabra out, dentro de la función cada parámetro de salida debe ser asignado para funcionar y poder regresar un valor.

## Probando funcionalidades de parámetros de salida
Si en nuestra función solamente necesitamos el primer parámetro de salida no podemos simplemente borrar los otros parámetros ya que esto va a lanzar un error, lo que debemos hacer es mandar una variable dummy en los siguientes parámetros de salida y listo.

## Sobrecargas de métodos
Vamos a optimizar nuestro código, para ello vamos a sobrecargar nuestro método GetObjetoEscuela para los casos donde necesitemos menos parámetros de salida.

## Listas de solo Lectura
Nuestro método GetObjetoEscuela nos regresa una lista que debe utilizarse solo para lectura de objetos, sin embargo, al regresar un objeto tipo List es posible para el desarrollador añadir nuevos objetos. Podemos solucionar esto cambiando el tipo List por IReadOnlyList.

Recuerda que una buena practica para las listas de datos que son de manera publica es regresar un tipo de lista genérico, como IEnumerable y en los casos donde serán de solo lectura regresar un tipo IReadOnlyList.

## Diccionario Polimórfico
El objeto tipo Dictionary necesita dos parámetros, el primero es la llave y el segundo es el contenido. Haciendo que la instancia de un Dictionary quede de la siguiente forma:

``` c#
Dictionary<int, string> diccionario = new Dictionary<int, string>();
```

Las llaves en los diccionarios son únicas.

## Uso de numeraciones en diccionario
Teniendo un diccionario que sus llaves sean de tipo string vamos a encontrarnos con un problema al momento de programar: podríamos equivocarnos en el nombre de la llave escribiendo “cursos” en lugar de “Cursos”, esto ocasionaría que estemos accediendo a un lugar distinto del diccionario.

Para solucionar nuestro problema podemos hacer uso de variables constantes, pero solamente funcionaria dentro del fragmento de código actual. Una mejor solución seria hacer uso de un enum con los distintos nombres de las llaves y cambiar el tipo de la llave del diccionario de string a enum.











## ⬇ Notas del curso [Fundamentos De C# con .Net Core](https://platzi.com/clases/fundamentos-csharp-2018/)

## Comandos Dotnet
- `dotnet new` Nuevo proyecto
- `dotnet new console` Para crear una aplicación de consola
- `dotnet run` Para ejecutar nuestra app
- `dotnet build` Para compilar nuestra app
- `dotnet build -c Release -r win10-x64` Para compilar para Windows10x64
- `dotnet new console --output platziHelloWorld` Para crear una aplicación de consola indicando el nombre del proyecto

## Historia de C#

- Creado por Anders Hejilsberg y su equipo, C# es un lenguaje multiparadigma fuertemente tipado, imperativo, declarativo, funcional, genérico, orientado a objetos y orientado a componentes.

- C# es un lenguaje multiparadigma

- Es un lenguaje strong typing(fuertemente tipado)
    - Imperativo
    - Declarativo
    - alineado con el paradigma Functional
    - orientado a objetos(basado en clases)
    - orientado a componentes

## Versiones de C# / ¿De dónde viene su nombre?
En un comienzo las versiones de C# iban agregando funcionalidades básicas o funcionalidades al core, luego llegaron versiones creando grandes bloques de funcionalidad y con el tiempo fue madurando el framework, entonces las nuevas versiones de C# lo que buscaban eran nuevas funcionalidades para escribir más rápido y amigable el código.

La versión 1.0 de C# era muy parecida a Java. A partir de la versión 2.0 empezaron a implementar nuevas ideas como los tipos parciales, métodos anónimos, iteradores entre otras cosas.

Para la versión 7.0 se incremento la velocidad de lanzamiento de una nueva versión, entonces empezaron a sacar C# 7.1, 7.2.

C# se pensó como una mejora al lenguaje C++, este lenguaje tiene su nombre por ser una mejora del lenguaje C, entonces llamar (C++)++ a C# hubiera quedado muy mal. Por ello se optó en llamarlo “C Sharp” que “Sharp “ significa inteligente, pero el símbolo de Sharp no es fácil de sacar con el teclado por ello se usa el signo #.

## Clases, objetos, métodos, acciones y atributos
**¿Qué puede ser descrito como un objeto?**

Todo puede ser descrito como un objeto, con ciertas características y métodos, por ejemplo:
Toda escuela tiene un nombre, una ubicación, un tipo, esas serian sus características. Mientras que sus métodos pueden ser iniciar clases, terminar clases, sonar el timbre, etc.

**Un objeto NO es una clase.**

La clase es la descripción de un objeto, pero no el objeto, más bien es una plantilla para crear objetos.

## Introducción a la Programación Orientada a Objetos
Cuando creamos un nuevo proyecto lo primero que nos encontraremos es una clase con el método Main, por convención este es el primer método que se ejecuta en una aplicación por consola.

Para definir una clase tenemos que usar la palabra reservada “class” antes del nombre de la clase a definir, todos sus métodos y atributos se encontraran dentro de las llaves o curly brackets.

Para crear una nueva instancia de una clase debemos crear una variable y asignarle la palabra reservada “new” seguido del nombre de la clase.

Cada cosa definida dentro de una clase tiene un nivel de acceso, por defecto el nivel de acceso es privado o protegido y esto significa que no pueden modificar o acceder a ese atributo. Para poder acceder por fuera de la clase se debe asignar el nivel de acceso publico con la palabra reservada “public”.

# Proyecto: CorEscuela

CorEscuela debe ser capaz de:

- Administrar una escuela pequeña.
- Manejar los alumnos de cada grado.
- Controlar sus asignaturas.
- Controlar sus evaluaciones.
- Elaborar informes.

# Formas de recorrer arreglos
Además de recorrer un arreglo con la sentencia `while` podemos encontrar:

- La sentencia `do while` donde a diferencia de while se va a ejecutar primero el código y luego va a verificar si la condición es válida.
- La sentencia `for`.
- La sentencia `foreach`.

# Inicializando arreglos y mejorando impresión
Es importante tener un código compacto siempre y cuando este favorezca la legibilidad del código.

Añadiendo al inicio de nuestro archivo la línea:

```c#
using static System.Console
```

Podremos escribir solo WriteLine cuando vayamos a imprimir algo en consola.


# Condiciones
El operador if nos indica si se cumple o no una condición, si la condición se cumple entonces ejecuta el bloque de código, en caso de no cumplirse no se ejecuta. La sentencia else se ejecuta cuando un if no se cumple y la sentencia else if lo que hace es en caso de no cumplirse un if, pregunta por una nueva condición.

Existen diferentes operadores que resultan útiles para verificar condicionales, algunos de ellos son:


- `||` o or.
- `&&` o and.
- `>` mayor que.
- `<` menor que.
- `%` operador MOD, retorna el residuo de una división.

# Operadores en C#
En el lenguaje de C# existen diferentes tipos de operadores, se encuentran los Aritméticos, Lógicos, Binarios y algunos por palabras clave.

Hay más de 40 operadores, la mayoría de ellos son combinaciones de tipos más básicos. [Todos los operadores](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/)

# Colecciones vs arreglos
> "Los arreglos son mucho más rápidos para trabajar en memoria, consumen menos memoria, si se utilizan tipos nativos son mucho más eficientes y son ideales para trabajar con APIS de bajo nivel.
Por otro lado, las colecciones son más fáciles de manipular, tienen múltiples variantes y, especializaciones para cada tarea, los tamaños son flexibles y las colecciones son extensibles y personalizables.

Hay muchos tipos de colecciones:

- Simple: manipulan todo como tipos `Object`; algunos ejemplos son el `ArrayList`, `BitArray`, `Queue`, `Stack` y `Sorted`.
- Especializadas: son diseñadas para manejar un tipo de dato especifico; algunos ejemplos son, `StringCollection`, `BitVector`, `ListDictionary` y `NameValueCollection`.
- Genéricas: son las más usadas hoy en día, algunos ejemplos son: `Dictionary<T,K>`, `List<T>`, `Queue<T>`, `Stack<T>`, `HashSet<T>` y `SortedSet<T>`.
- Concurrentes: son diseñadas para el acceso concurrente; algunos ejemplos son: `ConcurrentBad<T>`, `ConcurrentStack<T>` y `ConcurrentQueue<T>`.

Si quieres ver más tipos de colecciones que hay en C# visita el siguiente [enlace](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections).

# Implementando colecciones
Para añadir un nuevo objeto a la colección usaremos el método `Add`, si queremos añadir un conjunto de objetos en forma de colección podemos hacerlo mediante el método `AddRange` y para remover todos los miembros de la colección usamos el método `Clear`.

# Removiendo y buscando objetos en colecciones
Para eliminar un objeto especifico de una colección podemos hacerlo mediante referencia que es pasándole al método Remove la variable del objeto a eliminar, o también indicando el índice del objeto que queremos eliminar con el método RemoveAt.

El método RemoveAll pide como parámetro un Predicate el cual es una función que solamente va a regresar valores Bool y se va a ejecutar en cada elemento de la colección, de igual forma la función va a recibir como parámetro un elemento de la colección y en caso de que la condición regrese un valor de true entonces el objeto se va a borrar.

# Expresiones lambda y delegados
> Una expresión lambda es una función anónima que puedes usar para crear delegados, son bastante útiles pues tu código queda de forma más compacta, pero solamente si esta función se utilizara en un solo lugar.

En C# puedes comentar de distintas formas:

- Con `//` para comentar una sola línea.
- Con `/*` y `*/` para comentar varias líneas.
- Con `///` para comentar lo que hace un método especifico.

# Refactorizar
Es importante refactorizar nuestro código para mantenerlo ordenado.

El constructor de una clase tiene que ser tan rápido como sea posible, tiene que estar desconectado de cualquier cosa que implique entrada y salida.

# Clases estáticas
Una clase estática no permite crear nuevas instancias, la clase por si misma funciona como un objeto.

# Generación de datos aleatorios
Si un método tiene más de 50 líneas significa que está mal diseñado, cada método debe tener una sola responsabilidad. Es por eso por lo que vamos a separar en distintos métodos la carga de datos de nuestro proyecto.




