using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora11Marzo
{
    class Calculadora
    {
        public Calculadora()
        {

        }

        public void Iniciar()
        {
            int option = 0;
            do
            {
                ImprimirMenu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Suma();
                        break;
                    case 2:
                        Resta();
                        break;
                    case 3:
                        Producto();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("¡Opción incorrecta!");
                        break;
                }

            } while (option != 5);
        }

        private static void ImprimirMenu()
        {
            Console.WriteLine("------------------Menu---------------");
            Console.WriteLine("1) Suma \n 2) Resta \n 3) Multiplicar \n 4) División \n 5) Exit");
        }

        private static void Suma()
        {
            Console.WriteLine("Suma");
            Double num1 = GetNumber();
            Double num2 = GetNumber();
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        }

        private static void Resta()
        {
            Console.WriteLine("Suma");
            Double num1 = GetNumber();
            Double num2 = GetNumber();
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        }

        private static void Producto()
        {
            Console.WriteLine("Multiplicación");
            Double num1 = GetNumber();
            Double num2 = GetNumber();
            Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        }

        private static void Division()
        {
            Console.WriteLine("División");
            Double num1 = GetNumber();
            Double num2 = GetNumber();
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        }

        private static Double GetNumber()
        {
            Console.Write("Número: ");
            Double number = Double.Parse(Console.ReadLine());
            return number;
        }

    }
}
