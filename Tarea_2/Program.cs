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
