using System;

namespace Jueves12Marzo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PreguntarAlumno();

            MostrarEmpleado();

        }

        private static Empleado CrearEmpleado()
        {
            Console.Write("Nombre del empleado: ");
            string name = Console.ReadLine();
            Console.Write("Día de nacimiento: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Mes de nacimiento: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Año de nacimiento: ");
            int year = int.Parse(Console.ReadLine());

            Fecha fecha = new Fecha(day, month, year);

            //----METODO CON DATETIME----
            //Console.Write("Fecha de nacimiento (separado por /): ");
            //string date = Console.ReadLine();
            //string[] dates = date.Split("/");
            //int day = int.Parse(dates[0]);
            //int month = int.Parse(dates[1]);
            //int year = int.Parse(dates[2]);
            //DateTime fecha = new DateTime(year, day, month);

            return new Empleado(name, fecha.ToString());
        }
        private static void MostrarEmpleado()
        {
            Console.WriteLine(CrearEmpleado().ToString());
        }

        private static void PreguntarAlumno()
        {
            Alumno[] alumnos = new Alumno[3];

            for(int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("Nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.Write("Nota del alumno: ");
                float nota = float.Parse(Console.ReadLine());

                alumnos[i] = new Alumno(nombre, nota);
            }
            Console.WriteLine();
            Console.WriteLine("Notas: ");
            float media = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].MostrarAlumno();
                media += alumnos[i].GetNota();
            }
            Console.WriteLine("Nota media: "+(media/alumnos.Length));


        }
    }
}
