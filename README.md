# segundatarea
###  2.1 Declaración de clases: atributos, métodos, encapsulamiento.


*resumen*



Las clases (class) y estructuras (struct) son dos de las construcciones básicas de .NET Cada una de ellas es una estructura de datos que encapsula un conjunto de datos y comportamientos que forman un conjunto como una unidad lógica. Los datos y comportamientos son los miembros de la clase o estructura, e incluyen sus métodos, propiedades y eventos, entre otros elementos.

Una declaración de clase o estructura es como un plano que se utiliza para crear instancias u objetos en tiempo de ejecución. 

Una clase es un tipo de referencia. Cuando se crea un objeto de la clase, la variable a la que se asigna el objeto contiene solo una referencia a esa memoria. Cuando la referencia de objeto se asigna a una nueva variable, la nueva variable hace referencia al objeto original.

Una estructura es un tipo de valor. Cuando se crea una estructura, la variable a la que se asigna la estructura contiene los datos reales de ella. Cuando la estructura se asigna a una nueva variable, se copia. Por lo tanto, la nueva variable y la variable original contienen dos copias independientes de los mismos datos.

___
###  2.2 Instanciación de una clase.


la palabra clave new puede usarse como un operador, un modificador o una restricción.

1. Se usa para crear objetos e invocar constructores
2. También se usa para crear instancias de tipos anónimos
3. El operador new también se usa para invocar el constructor predeterminado para tipos de valor. 

___
###  2.3 Referencia al objeto actual. 

```c#
        private int valor;
        public void set_valor(int valor)
        {
            this.valor= valor;
        }
```

___
###  2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores. 


1. [Parámetros de métodos (Referencia de C#)](https://msdn.microsoft.com/es-ES/library/8f1hz171.aspx)


Si se declaran parámetros sin in, ref o out se pasan al método llamado por valor. Ese valor se puede cambiar en el método, pero el cambio se perderá cuando se devuelva el control al procedimiento que ha realizado la llamada. Si usa palabras clave de parámetros de método en la declaración del parámetro, puede modificar este comportamiento.


2. [params (Referencia de C#)](https://msdn.microsoft.com/es-es/library/w5zay9db.aspx)


params puede especificar un parámetro de método que toma un número variable de argumentos.


3. [out (Referencia de C#)](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx)


out especifica que este parámetro se pasa por referencia y se escribe mediante el método llamado.


4. [ref (Referencia de C#)](https://msdn.microsoft.com/es-es/library/14akc2c7.aspx)


ref especifica que este parámetro se pasa por referencia y puede ser leído o escrito por el método llamado.

___
###  2.5 Constructores y destructores: declaración, uso y aplicaciones.


Los constructores son métodos de clase que se ejecutan cuando se crea un objeto de un tipo determinado. 
estos tienen el mismo nombre que la clase.
A los constructores que no toman nigun parametro se les denomina constructor predeterminado debido a que no tienen ningun argumento para new.

___
###  2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.


Implementa una clase llamada Dado, la cual es una abstracción de los dados de algún juego.

    Debe de tener por lo menos las siguientes propiedades:

>-valor
>-color

    La clase debe contar por lo menos con:

      Dos constructores sobrecargados.

      Los operadores ==, <, > sobrecargados.

      El uso de la palabra clave this.

   

    Utiliza tu clase dentro del método Main de tu programa, creando tres dados, arrojándolos e imprimiendo el mejor de ellos 

    o si alguno es igual.


```c#
using System;

namespace Tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dado al =new Dado();
            al.set_color("azul");
            al.set_valor(1);
            al.Tirar();
            Dado bl=new Dado();
            bl.set_color("rojo");
            bl.set_valor(1);
            bl.Tirar();
            Dado cl=new Dado();
            cl.set_color("amarillo");
            cl.set_valor(1);
            bl.Tirar();
            Console.WriteLine("el dado fue {0} color {1}",al.get_valor(),al.get_color());
            Console.WriteLine("el dado fue {0} color {1}",bl.get_valor(),bl.get_color());
            Console.WriteLine("el dado fue {0} color {1}",cl.get_valor(),cl.get_color());

        }
    }
    class Dado
    {
        private int valor;
        private string color;
        private static Random aleatorio;
        public Dado()
        {
            this.valor=1;
            aleatorio = new Random();

        }

        public int get_valor()
        {
            return valor;
        }
        public void set_valor(int valor)
        {
            this.valor= valor;
        }
        public string get_color()
        {
            return color;
        }
        public void set_color(string color)
        {
            this.color= color;
        }

        public void Tirar()
        {
            valor= aleatorio.Next(1, 6);
            
        }
        public void Comparar()
        {
            Dado al =new Dado();
            al.set_valor(1);

        }
    }
}
```