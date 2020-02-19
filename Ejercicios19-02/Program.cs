using System;

namespace Ejercicios19_02
{
    class Program
    {
        private static Boolean seguir = true;
        static void Main(string[] args)
        {

            while (seguir)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(" ----------- MENU ----------- \n 1) Comparar Números \n 2) Número par o impar \n 3) Número múltiplo de otro \n 4) Número negativo o positivo \n 5) Frases \n 6) Media de notas \n 7) Altura \n 0) Salir");
                Console.Write("----> ");
                int option;
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Console.WriteLine("¡Hasta otra!");
                        seguir = false;
                        break;
                    case 1:
                        compararNumeros();
                        break;
                    case 2:
                        numeroParImpar();
                        break;
                    case 3:
                        numeroMultiplo();
                        break;
                    case 4:
                        numeroPositivo();
                        break;
                    case 5:
                        frases();
                        break;
                    case 6:
                        mediaNotas();
                        break;
                    case 7:
                        alturas();
                        break;
                    default:
                        Console.WriteLine("La opción elegida no existe.");
                        break;
                }
                
            }
        }

        private static Double getNumber()
        {
            Console.Write("Introduce un numero: ");
            Double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }

        private static void compararNumeros()
        {
            Double num1 = getNumber();
            Double num2 = getNumber();

            if (num1 == num2)
            {
                Console.WriteLine(num1 + " y " + num2 + " son iguales.");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num1+" es mayor que "+num2);
                }
                else
                {
                    Console.WriteLine(num2+" es mayor que "+num1);
                }
            }
        }

        private static void numeroParImpar()
        {
            Double num = getNumber();

            if (num % 2 == 0)
            {
                if (num == 0)
                {
                    Console.WriteLine(num + " es cero, ni par ni impar.");
                }
                else
                {
                    Console.WriteLine(num + " es par.");
                }
            }
            else
            {
                Console.WriteLine(num + " es impar.");
            }
        }

        private static void numeroMultiplo()
        {
            Double num1 = getNumber();
            Double num2 = getNumber();

            if (num1 % num2 == 0)
            {
                if(num1 == 0 || num2 == 0)
                {
                    Console.WriteLine("Algún numero introducido es 0.");
                }
                else
                {
                    Console.WriteLine(num1 + " es múltiplo de " + num2);
                }
            }
            else
            {
                Console.WriteLine(num1 + " NO es múltiplo de " + num2);
            }
        }

        private static void numeroPositivo()
        {
            Double num = getNumber();

            if (num == 0)
            {
                Console.WriteLine("El numero introducido es 0.");
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine(num+" es positivo.");
                }
                else
                {
                    Console.WriteLine(num + " es negativo.");
                }
            }
        }

        private static void frases()
        {
            Console.WriteLine("--- MENU LITERARIO --- \n 1) Refrán \n 2) Chiste \n 3) Insultar");
            Console.Write("---> ");
            int option;
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Más vale pájaro en mano que cientos volando.");
                    break;
                case 2:
                    Console.WriteLine("— ¿Qué le dice un techo a otro? \n — Techo de menos.");
                    break;
                case 3:
                    Console.WriteLine("CABRÓN HIJOPUTA");
                    break;
                default:
                    Console.WriteLine("La opción elegida no existe.");
                    break;
            }
        }

        private static void mediaNotas()
        {
            Console.Write("Introduce tres notas: ");
            String msg = Console.ReadLine();
            String [] numbers = msg.Split();
            float num1 = float.Parse(numbers[0]);
            float num2 = float.Parse(numbers[1]);
            float num3 = float.Parse(numbers[2]);

            float media = (num1 + num2 + num3) / 3;
            Console.WriteLine("La media de las notas es: " + media.ToString("0.00"));
        }

        private static void alturas()
        {
            Console.Write("Introduce tu altura (en cm): ");
            int alt = int.Parse(Console.ReadLine());

            if(alt > 0 && alt <= 175)
            {
                if (alt <= 135)
                {
                    Console.WriteLine("Eres más bajo que un gato.");
                }
                else
                {
                    Console.WriteLine("Eres un puto gnomo.");
                }
            }
            else if (alt > 175 && alt <= 255)
            {
                if (alt <= 215)
                {
                    Console.WriteLine("Eres un puto enano.");
                }
                else
                {
                    Console.WriteLine("Eres un puto bajito.");
                }
            }
            else
            {
                Console.WriteLine("A ver si crecemos un poco.");
            }

        }
        

    }
}
