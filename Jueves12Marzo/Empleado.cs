using System;
using System.Collections.Generic;
using System.Text;

namespace Jueves12Marzo
{
    struct Empleado
    {
        private string nombre;
        private string fecha;
        // ------- METODO CON DATETIME
        //private DateTime fecha;


        public Empleado(string n, string f)
        {
            this.nombre = n;
            this.fecha = f;

        }

        public override string ToString()
        {
            // ------- METODO CON DATETIME
            //return "El empleado "+this.nombre+" nació el "+this.fecha.Day+" del "+this.fecha.Month+" de "+this.fecha.Year;

            return "El empleado " + this.nombre + " nació el " + this.fecha;
        }
    }
}
