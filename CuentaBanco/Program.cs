using System;
using System.Collections.Generic;

namespace CuentaBanco
{
    class Program
    {
        private static List<Cliente> clientes;
        static void Main(string[] args)
        {
            clientes = new List<Cliente>();

            int option = 0;
            do
            {
                option = Menu();

                switch (option)
                {
                    case 1:
                        CrearCuenta();
                        break;
                    case 2:
                        BuscarCuenta();
                        break;
                    case 3:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (option!=3);

        }

        private static int Menu()
        {
            Console.WriteLine("-----------------Banco---------------- \n 1) Crear cuenta \n 2) Buscar cuenta \n 3) Salir");
            Console.Write("---> ");
            return int.Parse(Console.ReadLine());
        }

        private static void CrearCuenta()
        {
            Console.Write("Nombre del titular: ");
            string name = Console.ReadLine();
            Cliente c = new Cliente(name);

            if (clientes.Count == 0)
            {
                clientes.Add(c);
                Console.WriteLine("Cliente creado!");
            }
            else
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].GetNombre().Equals(c.GetNombre()))
                    {
                        Console.WriteLine("Ya existe una cuenta con este nombre.");
                    }
                    else
                    {
                        clientes.Add(c);
                        Console.WriteLine("Cliente creado!");
                    }
                }
            }
        }


        private static void BuscarCuenta()
        {
            Console.WriteLine("Nombre del titular: ");
            string name = Console.ReadLine();

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].GetNombre().Equals(name))
                {
                    MenuTransaccion(clientes[i]);
                }
                else
                {
                    Console.WriteLine("La cuenta "+name+" no existe.");
                }
            }

        }

        private static void MenuTransaccion(Cliente c)
        {
            int option2 = 0;
            do
            {
                Console.WriteLine("---------------- \n 1) Ingresar/sacar dinero \n 2) Mostrar info \n 3) Salir");
                Console.Write("---> ");
                option2 = int.Parse(Console.ReadLine());

                switch (option2)
                {
                    case 1:
                        IngresarOSacarDinero(c);
                        break;
                    case 2:
                        MostrarInfo(c);
                        break;
                    case 3:
                        Console.WriteLine("Volviendo atrás...");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (option2 != 3);
        }

        private static void MostrarInfo(Cliente c)
        {
            if (c.GetTransacciones().Count == 0)
            {
                Console.WriteLine("La cuenta no ha realizado ninguna transacción.");
            }
            else
            {
                c.MostrarTransacciones();
            }
        }

        private static void IngresarOSacarDinero(Cliente c)
        {
            Console.WriteLine("---------------- \n 1) Ingresar \n 2) Sacar");
            Console.Write("---> ");
            int option3 = int.Parse(Console.ReadLine());
            if(option3 == 1)
            {
                Console.Write("Concepto: ");
                string concept = Console.ReadLine();
                Console.Write("Cantidad: ");
                int cant = int.Parse(Console.ReadLine());
                Transaction transaccion = new Transaction(cant, concept);
                c.AddTransaction(transaccion);
            }else if(option3 == 2)
            {
                Console.Write("Concepto: ");
                string concept = Console.ReadLine();
                Console.Write("Cantidad: ");
                int cant = int.Parse(Console.ReadLine());
                cant = cant * (-1);
                Transaction transaccion = new Transaction(cant, concept);
                c.AddTransaction(transaccion);
            }
            else
            {
                Console.WriteLine("Opción incorrecta!");
            }
        }
    }
}
