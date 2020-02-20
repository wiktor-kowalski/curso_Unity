using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //sumaNumeros();

            //Ejercicio 2
            copiaArray();
        }

        private static void sumaNumeros()
        {
            
            Console.Write("¿Cuántos números vas a introducir? ");
            int repeat = int.Parse(Console.ReadLine());
            int[] numbers = new int[repeat];
            int total = 0;

            for (int i=0; i<numbers.Length; i++)
            {
                Console.Write("Introduce un número: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine("La suma de los números es: "+total);

        }

        private static void copiaArray()
        {
            Console.Write("¿Cuántos números vas a introducir? ");
            int repeat = int.Parse(Console.ReadLine());
            int[] numbers = new int[repeat];
            int total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Introduce un número: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int[] numbers2 = new int[numbers.Length];
            for(int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = numbers[i];
            }

            Console.WriteLine("Contenido del segundo array: ");
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }


        }
    }
}
