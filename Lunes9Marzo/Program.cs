using System;
using System.Collections.Generic;

namespace Lunes9Marzo
{
    class Program
    {
        private static List<int> numeros;

        static void Main(string[] args)
        {
            //Ejercicios 1 y 2
            //numeros = new List<int>();

            //rellenarArray(numeros);

            //Console.WriteLine("Numeros");
            //foreach(int n in numeros)
            //{
            //    Console.Write(" "+n);
            //}

            //Ejercicio 2
            //paresImpares(numeros);

            //Ejercicio 3
            //paresImparesContando(numeros);

            //Ejercicio 4
            tablaMultiplicar();
        }

        private static void rellenarArray(List<int> numeros)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros.Add(rnd.Next(100));
            }
        }

        //Ejercicio 2
        private static void paresImpares(List<int> numeros)
        {

            int pares = 0, impares = 0;
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }


            Console.WriteLine();
            Console.WriteLine("Hay " + pares + " números pares.");

            Console.WriteLine();
            Console.WriteLine("Hay " + impares + " números impares.");

            Console.WriteLine();
        }

        //Ejercicio 3
        private static void paresImparesContando(List<int> numeros)
        {
            List<int> listaPar = new List<int>();
            List<int> listaImpar = new List<int>();
            int pares = 0, impares = 0;
            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                {
                    pares++;
                    listaPar.Add(num);
                }
                else
                {
                    impares++;
                    listaImpar.Add(num);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Hay " + pares + " números pares: ");
            foreach (int num in listaPar)
            {
                Console.Write(" " + num);
            }
            Console.WriteLine();
            Console.WriteLine("Hay " + impares + " números impares: ");
            foreach (int number in listaImpar)
            {
                Console.Write(" " + number);
            }
        }


        //Ejercicio 4
        private static void tablaMultiplicar()
        {
            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());

            int[] tabla = new int[11];

            for(int i = 0; i <= 10; i++)
            {
                tabla[i] = num * i;
            }
            Console.WriteLine("Tabla de multiplicar: ");
            for(int j = 0; j <= 10; j++)
            {
                Console.WriteLine(tabla[j]);
            }
        }



    }
}
