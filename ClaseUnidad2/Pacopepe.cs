using System;

namespace ClaseUnidad2
{
    public class Pacopepe : Malo
    {
        private String nombre;
        private int edad;

        public Pacopepe(String nombre, int edad)
        {
            setNombre(nombre);
            setEdad(edad);
        }

        void setNombre(String n)
        {
            this.nombre = n;
        }

        void setEdad(int e)
        {
            this.edad = e;
        }

        String getNombre()
        {
            return this.nombre;
        }

        int getEdad()
        {
            return this.edad;
        }

        public String toString()
        {
            String msg = "Este Paco Pepe se llama "+this.getNombre()+" y tiene "+this.getEdad()+" años.";
            return msg;
        }

        public void esMalo()
        {
            Console.WriteLine("PacoPepe siempre es malo");
        }

    }
}
