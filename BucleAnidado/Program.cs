using System;
using System.Collections.Generic;

namespace BucleAnidado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //cambiarValores();

            //Ejercicio 2 
            //ordenarArray();

            //Ejercicio 3
            //asteriscos();

            //Ejercicios 4
            //duplicado();
            //duplicado2();

            //Ejercicio5
            //valorMinMax();

            //Ejercicio 6
            //piramideNumeros();

            //Ejercicio 7
            //separarParesImpares();

            //Ejercicio 8
            //diagonalPrincipal();

            //Listas
            listas();
        }

        static int getNumber()
        {
            Console.Write("Introduce un número: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        //Metodo para preguntar la magnitud de un array y sus valores
        static int[] getNumbers()
        {
            Console.Write("¿Cuántos números vas a introducir? ");
            int repeat = int.Parse(Console.ReadLine());
            int[] numbers = new int[repeat];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = getNumber();
            }

            return numbers;
        }

        //Metodo para cambiar los valores de dos variables
        static void cambiarValores()
        {
            int aux;
            int x = getNumber();
            int y = getNumber();

            Console.WriteLine("X = " + x + " Y = " + y);
            Console.WriteLine("Cambiando valores...");
            aux = x;
            x = y;
            y = aux;
            Console.WriteLine("X = " + x + " Y = " + y);
        }

        static void ordenarArray()
        {
            int[] numbers = getNumbers();
            int aux;

            //Metodo de la burbuja
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        aux = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = aux;
                    }
                }
            }

            //Mostramos el array por consola
            Console.WriteLine("Array ordenado: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        //Pintamos tantas líneas de asteriscos como el usuario quiera
        static void asteriscos()
        {
            Console.Write("¿Cuántos filas de asteriscos quieres? ");
            int repeat = int.Parse(Console.ReadLine());
            String asterisco = "*";

            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(asterisco);
                }
                Console.WriteLine();
            }
        }

        //comprobamos si hay un duplicado en el array
        static void duplicado()
        {
            int[] numbers = getNumbers();
            int aux = 0;
            bool duplicado = false;

            //Metodo de la burbuja
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicado = true;
                        aux = numbers[i];
                       
                    }
                }
            }

            if (duplicado)
            {
                Console.WriteLine("Hay un duplicado: " + aux);
            }
            else
            {
                Console.WriteLine("No hay ningún duplicado.");
            }

        }

        //Comprobar si hay varios duplicados en un array
        static void duplicado2()
        {
            int[] numbers = getNumbers();
            int aux = 0;
            bool duplicado = false;

            List<int> duplicados = new List<int>();

            //Metodo de la burbuja
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    //Si el elemento i es igual a cualquier otro del array
                    if (numbers[i] == numbers[j])
                    {
                        duplicado = true;
                        aux = numbers[i];

                        //Tenemos el numero duplicado en la variable auxiliar
                        if (duplicados.Count == 0)
                        {
                            //si la lista de duplicados esta vacia lo metemos
                            duplicados.Add(aux);
                        }
                        else
                        {
                            //si la lista de duplicados no esta vacia
                            //Comprobamos si el numero no esta ya en la lista para no repetirlo
                            for (int z = 0; z < duplicados.Count; z++)
                            {
                                if (duplicados[z] == aux)
                                {
                                    //Esta ya en el array
                                }
                                else
                                {
                                    //Si no esta en el array lo metemos
                                    duplicados.Add(aux);
                                }
                            }                           
                        }
                        

                    }
                }
            }

            if (duplicado)
            {
                Console.WriteLine("Duplicados: ");
                foreach (int number in duplicados)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("No hay ningún duplicado.");
            }

        }

        static void valorMinMax()
        {
            int[] numbers = getNumbers();
            int max = int.MinValue, min = int.MaxValue;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                else if(numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine("Máximo: " + max + " || Mínimo: " + min);
        }


        static void piramideNumeros()
        {
            Console.Write("¿Cuántos filas de números quieres? ");
            int repeat = int.Parse(Console.ReadLine());

            //primera piramide
            int num = 1;
            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((num++)+" ");
                }
                num = 1;
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");
            //Segunda piramide
            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((i+1)+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------------");
            //tercera piramide
            int number = 1;
            for (int i = 0; i < repeat; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((number++)+" ");
                }
                Console.WriteLine();
            }

        }


        static void separarParesImpares()
        {
            //Array
            int[] numbers = getNumbers();
            //Listas
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();
            //Recorremos el array
            for (int i = 0; i < numbers.Length; i++)
            {
                //Si el elemento del array es par
                if (numbers[i] % 2 == 0)
                {
                    pares.Add(numbers[i]);
                }
                else
                {
                    //Si el elemento del array  es impar
                    impares.Add(numbers[i]);
                }
            }
            
            //Si hay pares e impares
            if(pares.Count > 0 && impares.Count > 0)
            {
                Console.WriteLine("Números pares: ");
                foreach (int par in pares)
                {
                    Console.WriteLine(par);
                }

                Console.WriteLine("Números impares: ");
                foreach (int impar in impares)
                {
                    Console.WriteLine(impar);
                }
            }
            else if(pares.Count > 0)
            {
                //solo hay pares
                Console.WriteLine("Números pares: ");
                foreach (int par in pares)
                {
                    Console.WriteLine(par);
                }
            }
            else
            {
                //solo hay impares
                Console.WriteLine("Números impares: ");
                foreach (int impar in impares)
                {
                    Console.WriteLine(impar);
                }
            }
        }


        static void diagonalPrincipal()
        {
            Console.Write("¿Cuántas filas quieres? ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("¿Cuántas columnas quieres? ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] array = new int[filas, columnas];

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void listas()
        {
            List<Punto3D> puntos = new List<Punto3D>();

            Punto3D p1 = new Punto3D(1,1,1);
            Punto3D p2 = new Punto3D(2,2,2);
            Punto3D p3 = new Punto3D(3,3,3);
            Punto3D p4 = new Punto3D(4,4,4);

            puntos.Add(p1); puntos.Add(p2); puntos.Add(p3); puntos.Add(p4);

            foreach(Punto3D punto in puntos)
            {
                Console.WriteLine(punto.toString());
            }

        }

    }
}
