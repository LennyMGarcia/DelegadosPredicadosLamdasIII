using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLamdasIII
{
    class Program
    {
        static void Main(string[] args)
        {


            Personas p1 = new Personas();
            p1.Nombre = "Juan";
            p1.Edad = 18;

            Personas p2 = new Personas();
            p2.Nombre = "Maria";
            p2.Edad = 18;

            Personas p3 = new Personas();
            p3.Nombre = "Josefa";
            p3.Edad =18;
            //expresion lamda para hacerte la vida mas facil en ves de realizar el metodo para el delegado
            //mas de un parametros en la expresion lambda deben estar entre parentesis
            /*operacionesMatematicas operaciones= new operacionesMatematicas((num2, num1) => num1+num2);

            Console.WriteLine(operaciones(4, 7));

            List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
            //encuentra dentro de la lista y a cada valor i se modula  hasta que se cumpla la condicion
            List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);
            //lambdeado
            //a cada vuelta del bucle en numeros se le asigna la variable numero a cada valor e imprime cada numero que cumpla la condicion de arriba
            //siempre que haya mas de una linea de codigo en la expreseion dicho codigo a la derecha se pone en llaves
            numerosPares.ForEach(numero => {
                Console.Write("el numero par es ");
                Console.WriteLine(numero); } );*/

            //foreach (int modnumero in numerosPares) Console.WriteLine(modnumero);

            comparaPersonas comparaEdad = (persona1, persona2) => persona1 == persona2;

            Console.WriteLine(comparaEdad(p1.Edad, p2.Edad));

        }
        public delegate bool comparaPersonas(int edad1, int edad2);

        //public delegate int operacionesMatematicas(int numero1, int numero2);

        /*public static int cuadradro( int num)
        {
            return num * num;
        }

        public static int suma( int num1, int num2)
        {
            return num1 + num2;   
        }*/
    }
    class Personas
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public int Edad { get => edad; set => edad = value; }

        private int edad;
    }
}

