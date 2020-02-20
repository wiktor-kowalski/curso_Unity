using System;

namespace Bucles
{
    class Program
    {
        private static Boolean exit = false;
        static void Main(string[] args)
        {
            while (!exit)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(" ----------- MENU ----------- \n 1) Tabla de multiplicar (While) \n 2) Tabla de multiplicar (Do-While) \n 3) Tabla de multiplicar (For) \n 0) Salir");
                Console.Write("----> ");
                int option;
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("¡Hasta otra!");
                        exit = true;
                        break;
                    case 1:
                        tablaMultiplicar();
                        break;
                    case 2:
                        bucleDoWhile();
                        break;
                    case 3:
                        bucleFor();
                        break;
                    default:
                        Console.WriteLine("La opción elegida no existe.");
                        break;
                }
            }
        }

        private static void tablaMultiplicar()
        {
            Console.Write("Tabla de multiplicar del número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Hasta el número: ");
            int repeat = int.Parse(Console.ReadLine());

            //Aqui el contador va de 0 a 7
            int cont = 0;
            while (cont++ < repeat)
            {
                //Como cont++ esta en la condicion, aqui el valor de cont va de 1 a 8
                Console.WriteLine(num + " x " + cont + " = " + (num * cont));
            }
        }

        private static void bucleDoWhile()
        {
            Console.Write("Tabla de multiplicar del número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Hasta el número: ");
            int repeat = int.Parse(Console.ReadLine());

            int cont = 0;
            do
            {
                cont++;
                Console.WriteLine(num + " x " + cont + " = " + (num * cont));
            } while (cont < repeat);
            
        }

        private static void bucleFor()
        {
            Console.Write("Tabla de multiplicar del número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Hasta el número: ");
            int repeat = int.Parse(Console.ReadLine());

            for(int i=1; i<=repeat; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
        }

    }
}
