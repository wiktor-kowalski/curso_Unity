using System;
using System.Collections.Generic;
using System.Text;

namespace Jueves12Marzo
{
    public struct Alumno
    {
        private string nombre;
        private float nota;

        public Alumno(string n, float nt)
        {
            this.nombre = n;
            this.nota = nt;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public float GetNota()
        {
            return this.nota;
        }
        public void SetNota(float nota)
        {
            this.nota = nota;
        }

        public void MostrarAlumno()
        {
            Console.WriteLine("Nombre: " + this.nombre + " \n Nota: " + this.nota);
        }

    }
}
