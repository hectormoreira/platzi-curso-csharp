# Fundamentos de C# con .NET Core 2018

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




