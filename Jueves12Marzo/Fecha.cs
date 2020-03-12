using System;
using System.Collections.Generic;
using System.Text;

namespace Jueves12Marzo
{
    public struct Fecha
    {
        private int day;
        private int month;
        private int year;

        public Fecha(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }

        public override string ToString()
        {
            return this.day+"/"+this.month+"/"+this.year;
        }
    }
}
