using System;
using System.Collections.Generic;

namespace Miercoles11Marzo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1
            //ejercicio1();

            //ejercicio2
            //ejercicio2();

            //ejercicio3
            //ejercicio3();

            //ejercicio4
            //ejercicio4();

            //5
            //ejercicio5();

            //6
            //ejercicio6();

            //7
            //ejercicio7();

            //8
            //ejercicio8();

            //9
            ejercicio9();

        }

        private static void ejercicio9()
        {
            List<int> numbers = askTheseNumbersList();
            int aux = 0;

            Console.WriteLine("Lista ordenada de menor mayor: ");
            for (int i = 0; i < numbers.Count; i++)
            {
                for(int j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[i] > numbers[j])
                    {
                        aux = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = aux;
                    }
                }
                Console.Write(" "+numbers[i]);
            }
        }

        private static void ejercicio8()
        {
            List<int> numbers = askTheseNumbersList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.Write(" "+numbers[i]);
            }
        }

        private static void ejercicio7()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
                Console.Write(" " + numbers[i]);
            }

        }

        private static void ejercicio6()
        {
            int[] numbers = askTheseNumbers();
            int aux = 0;

            Console.WriteLine("Ordenado de menor a mayor: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
                Console.Write(" " + numbers[i]);
            }
        }

        private static void ejercicio5()
        {
            int[] numbers = askTheseNumbers();
            int repeats = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        repeats ++;
                    }
                }
            }

            Console.WriteLine("Números repetidos: "+repeats);
        }

        private static void ejercicio4()
        {
            int[] numbers = askTheseNumbers();
            int[] numbers2 = new int[numbers.Length];

            Console.WriteLine("Array copia: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = numbers[i];
                Console.Write(" " + numbers2[i]);
            }

        }

        private static void ejercicio3()
        {
            int[] numbers = askTheseNumbers();
            int total = 0;

            for(int i = 0; i< numbers.Length; i++)
            {
                total += numbers[i];
            }

            Console.WriteLine("La suma total es: " + total);
        }

        private static void ejercicio2()
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = askNumber();
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + numbers[i]);
            }

        }

        private static void ejercicio1()
        {
            int[] numbers = new int[10];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = (i + 1);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static int askNumber()
        {
            Console.Write("Dime un número: ");
            return int.Parse(Console.ReadLine());
        }

        private static int[] askTheseNumbers()
        {
            Console.Write("¿Cuántos números vas a introducir? ");
            int num = int.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = askNumber();
            }

            return numbers;
        }

        private static List<int> askTheseNumbersList()
        {
            Console.Write("¿Cuántos números vas a introducir? ");
            int num = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < num; i++)
            {
                numbers.Add(askNumber());
            }

            return numbers;
        }

    }
}
