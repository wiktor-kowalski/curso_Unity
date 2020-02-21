using System;
using System.Collections.Generic;
using System.Text;

namespace BucleAnidado
{
    class Punto3D
    {
        //Atributos
        private int x;
        private int y;
        private int z;


        //Constructor
        public Punto3D(int x, int y, int z)
        {
            this.setX(x);
            this.setY(y);
            this.setZ(z);
        }

        //Getters y setters
        public void setX(int x)
        {
            this.x = x;
        }
        public int getX()
        {
            return x;
        }
        private void setY(int y)
        {
            this.y = y;
        }
        public int getY()
        {
            return y;
        }
        private void setZ(int z)
        {
            this.z = z;
        }
        public int getZ()
        {
            return z;
        }

        public String toString()
        {
            return "("+this.getX()+","+this.getY()+","+this.getZ()+")";
        }

    }
}
