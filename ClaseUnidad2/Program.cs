using System;

namespace ClaseUnidad2
{
    class Program
    {
        private static Pacopepe paco;
        private static bool exit = true;
        
        static void Main(string[] args)
        {
            //Paco pepe
            //Console.WriteLine("Crea tu Paco pepe!");
            //Console.Write("Nombre: ");
            //String nombrePaco = Console.ReadLine();
            //Console.Write("Edad: ");
            //String edadPaco = Console.ReadLine();
            //int edadPaco1 = Int32.Parse(edadPaco);

            //paco = new Pacopepe(nombrePaco, edadPaco1);
            //Console.WriteLine(paco.toString());
            //paco.esMalo();

            //Float lleva una f al final y double una d
            float f = 3.14f;
            double w = 3.14159d;

            double num1, num2;
            while (exit)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Menu: \n 1) Sumar \n 2) Restar \n 3) Producto \n 4) Division \n 5) Comparar frases \n 6) Edad \n 7) Nota \n 8) Cartas \n 0) Salir");
                Console.Write("--->");
                String option = Console.ReadLine();
                int option2 = int.Parse(option);

                switch (option2)
                {
                    case 1:
                        num1 = getNumber();
                        num2 = getNumber();
                        suma(num1, num2);
                        break;
                    case 2:
                        num1 = getNumber();
                        num2 = getNumber();
                        resta(num1, num2);
                        break;
                    case 3:
                        num1 = getNumber();
                        num2 = getNumber();
                        producto(num1, num2);
                        break;
                    case 4:
                        num1 = getNumber();
                        num2 = getNumber();
                        Division(num1, num2);
                        break;
                    case 5:
                        compararFrases();
                        break;
                    case 6:
                        edad();
                        break;
                    case 7:
                        calificarNota();
                        break;
                    case 8:
                        cartas();
                        break;
                    case 0:
                        Console.WriteLine("¡Hasta otra!");
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("La opción que has elegido no existe.");
                        break;
                }
            }

        }

        static double getNumber()
        {
            //Variable
            double num1;
            //La pedimos por teclado
            Console.Write("Introduce un numero: ");
            String num1_1 = Console.ReadLine();
            //Pasamos de String a Double
            num1 = Convert.ToDouble(num1_1);

            return num1;
        }

        static void suma(double num1, double num2)
        {
            Console.WriteLine("La suma de " + num1 + " + " + num2 + " = " + (num1+num2));
        }

        static void resta(double num1, double num2)
        {
            Console.WriteLine("La resta de " + num1 + " - " + num2 + " = " + (num1 - num2));
        }

        static void producto(double num1, double num2)
        {
            Console.WriteLine("El producto de " + num1 + " * " + num2 + " = " + (num1*num2));
        }

        static void Division(double num1, double num2)
        {
            Console.WriteLine("La división de " + num1 + " / " + num2 + " = " +(num1/num2) + "\n El resto es: "+(num1 % num2));
        }

        static void compararFrases()
        {
            Console.Write("Escribe una frase: ");
            String msg = Console.ReadLine();
            Console.Write("Escribe otra frase: ");
            String msg2 = Console.ReadLine();
            if (msg.Equals(msg2))
            {
                Console.WriteLine("--->"+msg + " y " + msg2 + " son iguales.");
            }
            else if (msg.Equals(msg2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("--->" + msg + " y " + msg2 + " son iguales, pero cambian minúsculas y mayúsculas.");
            }
            else
            {
                Console.WriteLine("--->" + msg + " y " + msg2 + " NO son iguales.");
            }
        }

        static void edad()
        {
            Console.Write("¿Cuántos años tienes? ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 110){
                Console.WriteLine("---> Probablemente estés muerto.");
            }
            else if (age >= 65){
                Console.WriteLine("---> Eres jubilado.");
            }else if (age >= 18){
                Console.WriteLine("---> Eres mayor de edad.");
            }
            else{
                Console.WriteLine("---> Eres menor de edad.");
            }
        }

        static void calificarNota()
        {
            Console.Write("¿Qué nota has sacado? ");
            float nota = float.Parse(Console.ReadLine());

            if (nota>=0 && nota<5)
            {
                Console.WriteLine("Insuficiente");
            }
            else if (nota>=5 && nota<6)
            {
                Console.WriteLine("Suficiente");
            }
            else if (nota>=6 && nota<7)
            {
                Console.WriteLine("Bien");
            }
            else if (nota>=7 && nota<9)
            {
                Console.WriteLine("Notable");
            }
            else if (nota>=9 && nota<=10)
            {
                Console.WriteLine("Sobresaliente");
            }
            else{
                Console.WriteLine("Tu nota es inválida.");
            }
        }

        static void cartas()
        {
            Console.Write("Número de la carta: ");
            int carta = int.Parse(Console.ReadLine());

            switch (carta)
            {
                case 14:
                    Console.WriteLine("---> La carta es el Joker");
                    break;
                case 13:
                    Console.WriteLine("---> La carta es el Rey");
                    break;
                case 12:
                    Console.WriteLine("---> La carta es la Reina");
                    break;
                case 11:
                    Console.WriteLine("---> La carta es la Jota");
                    break;
                case 10:
                case 9:
                case 8:
                case 7:
                case 6:
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("---> La carta es la carta " + carta);
                    break;
                 /* 
                  * Otra forma de switch para añadir rangos de valores (no funciona)
                  * case carta <= 0 && carta > 14:
                  * Console.WriteLine("La carta con el número " + carta + " no existe.");
                  * break;
                 */
                default:
                    Console.WriteLine("La carta con el número " + carta + " no existe.");
                    break;

            }
        }


    }
}
