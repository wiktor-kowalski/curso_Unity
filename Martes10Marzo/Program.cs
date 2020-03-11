using System;

namespace Martes10Marzo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1
            //pintarDel1Al10();

            //Ejercicio2
            //sumaDel1Al10();

            //Ejercicio3
            //sumaHastaNumero();

            //Ejercicio4
            //sumaDeNumerosIntroducidos();

            //Ejercicio5
            //cuboDeNumeros();

            //Ejercicio6
            //tablaDeMultiplicar();

            //Ejercicio7
            //quitarPares();

            //Ejercicio8
            //escaleraAsteriscos();

            ////Ejercicio9
            //escaleraNumeros();

            ////Ejercicio10
            //escaleraNumeros2();

            ////Ejercicio11
            //escaleraNumeros3();

            //Ejercicio12
            factorialNumero();
        }

        //1
        private static void pintarDel1Al10()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            int j = 1;
            while (j < 11)
            {
                Console.Write(" " + j);
                j++;
            }
            Console.WriteLine();
            int k = 1;
            do
            {
                Console.Write(" " + k);
                k++;
            } while (k < 11);
        }

        //2
        private static void sumaDel1Al10()
        {
            int total;
            int i;
            for (i = 1, total = 0; i < 11; i++)
            {
                total += i;
            }
            Console.WriteLine("Total: " + total);
            total = 0; i = 1;
            while (i < 11)
            {
                total += i;
                i++;
            }
            Console.WriteLine("Total: " + total);
            total = 0; i = 1;
            do
            {
                total += i;
                i++;
            } while (i < 11);
            Console.WriteLine("Total: " + total);
        }

        //3
        private static void sumaHastaNumero()
        {
            Console.WriteLine("Introduce un número: ");
            int num = int.Parse(Console.ReadLine());
            int i, total;
            for (i = 0, total = 0; i < num; i++)
            {
                Console.Write(" " + (i + 1));
                total += (i + 1);
            }
            Console.Write(" -- Total: " + total);
            Console.WriteLine();
            i = 0; total = 0;
            while (i < num)
            {
                i++;
                Console.Write(" " + i);
                total += i;
            }
            Console.Write(" -- Total: " + total);
            Console.WriteLine();
            i = 0; total = 0;
            do
            {
                i++;
                Console.Write(" " + i);
                total += i;
            } while (i < num);
            Console.Write(" -- Total: " + total);
        }


        //4
        private static void sumaDeNumerosIntroducidos() {

            int i; int total;

            for (i = 0, total = 0; i < 10; i++)
            {
                Console.WriteLine("Número: ");
                total += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Suma total: " + total);

            i = 0; total = 0;
            while (i < 10)
            {
                Console.WriteLine("Número: ");
                total += int.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Suma total: " + total);
            i = 0; total = 0;

            do
            {
                Console.WriteLine("Número: ");
                total += int.Parse(Console.ReadLine());
                i++;
            } while (i < 10);
            Console.WriteLine("Suma total: " + total);

        }


        //5
        private static void cuboDeNumeros()
        {
            Console.Write("Introduce un número: ");
            int n = int.Parse(Console.ReadLine());

            int i; int cubo = 1;
            for (i = 1; i <= n; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    cubo = cubo * i;
                }

                Console.WriteLine("El cubo de " + i + " es " + cubo);
                cubo = 1;
            }

        }

        //6
        private static void tablaDeMultiplicar()
        {
            Console.Write("Introduce un número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + " x " + i + " = " + (n * i));
            }
        }

        //7
        private static void quitarPares()
        {
            Console.Write("Introduce un número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=2)
            {
                Console.Write(" "+i);
            }
        }

        //8
        private static void escaleraAsteriscos()
        {
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i ; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        //9
        private static void escaleraNumeros()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write((j+1)+" ");
                }
                Console.WriteLine();
            }
        }

        //10
        private static void escaleraNumeros2()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }


        //11
        private static void escaleraNumeros3()
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j < i; j++, num++)
                {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }

        //12
        private static void factorialNumero()
        {
            Console.Write("Introduce un número: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= n; i ++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial de "+n+" es "+factorial);

        }


    }
}
