using System;

namespace Bucles2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios del 20/02/2020

            //Ejercicio 1
            //sucesionNumeros();

            //Ejercicio 2
            //sumaSucesion();

            //Ejercicio 3
            //sucesionNumerosRegresiva();

            //Ejercicio 4
            //menuLiterario();

            //Ejercicio 5
            //suma10Numeros();

            //Ejercicio 5-2
            sumaNumeros();
        }

        public static int getNumberInt()
        {
            int num = 0;
            Console.Write("Introduce un número: ");
            String msg = Console.ReadLine();
            try
            {
                num = int.Parse(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return num;
        }

        public static int getNumberIntMenu(){
            int num = 0;
            Console.Write("----> ");
            String msg = Console.ReadLine();
            try
            {
                num = int.Parse(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return num;
        }

        public static int[] get10NumbersInt()
        {
            String[] numbers_string;
            int[] numbers;

            do
            {
                Console.Write("Introduce diez números: ");
                String msg = Console.ReadLine();
                numbers_string = msg.Split(" ");
                numbers = new int[numbers_string.Length];

                for (int i = 0; i < numbers_string.Length; i++)
                {
                    numbers[i] = int.Parse(numbers_string[i]);
                }

            } while (numbers_string.Length!=10);

            return numbers;
        }

        public static void sucesionNumeros()
        {
            int limit = getNumberInt();
            for(int i=1; i<=limit; i++)
            {
                Console.WriteLine("\t" + i);
            }

            Console.WriteLine("------------------");
            int counter = 1;
            do
            {
                Console.WriteLine("\t" + counter);
                counter++;
            } while (counter <= limit);
            
            Console.WriteLine("------------------");
            counter = 1;
            while (counter <= limit)
            {
                Console.WriteLine("\t"+counter);
                counter++;
            }    
        }


        public static void sumaSucesion()
        {
            int limit = getNumberInt();
            int aux = 0;
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine("\t" + i);
                aux = aux + i;
            }

            Console.WriteLine("------------------");
            int counter = 1;
            do
            {
                Console.WriteLine("\t" + counter);
                counter++;
            } while (counter <= limit);

            Console.WriteLine("------------------");
            counter = 1;
            while (counter <= limit)
            {
                Console.WriteLine("\t" + counter);
                counter++;
            }

            Console.WriteLine("\n \t" + aux);
        }


        public static void sucesionNumerosRegresiva()
        {
            int limit = getNumberInt();
            for(int i = limit; i >= 1; i--)
            {
                Console.WriteLine("\t"+i);
            }
        }

        public static void menuLiterario()
        {
            int option;
            do
            {
                Console.WriteLine(" ---------- Menu ----------");
                Console.WriteLine("\t 1) Refran \n \t 2) Chiste \n \t 3) Insulto \n \t 4) Salir");
                option = getNumberIntMenu();
                switch (option)
                {
                    case 1:
                        Console.WriteLine("No por madrugar amanece más temprano.");
                        break;
                    case 2:
                        Console.WriteLine("— Hola, ¿está Agustín? \n — No, estoy incomodín");
                        break;
                    case 3:
                        Console.WriteLine("Cabrón!");
                        break;
                    case 4:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("No existe esta opción, elige otra.");
                        break;
                }
                Console.WriteLine("----------------------------------------------");
            } while (option != 4);

        }

        public static void suma10Numeros()
        {
            int[] numbers = get10NumbersInt();
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine("La suma total es "+total);
        }

        public static void sumaNumeros()
        {
            Console.Write("¿Cuántos números quieres introducir? ");
            int repetitions = int.Parse(Console.ReadLine());
            int total = 0;
            for(int i = 0; i< repetitions; i++)
            {
                int number = getNumberInt();
                total += number;
            }
            Console.WriteLine("El total es: "+total);
        }

    }
}
