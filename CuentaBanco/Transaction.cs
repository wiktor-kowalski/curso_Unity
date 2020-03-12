using System;
using System.Collections.Generic;
using System.Text;

namespace CuentaBanco
{
    public struct Transaction
    {
        private float cantidad;
        private string concepto;

        public Transaction(float c, string cnp)
        {
            this.cantidad = c;
            this.concepto = cnp;
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }

        public string GetConcepto()
        {
            return this.concepto;
        }

        public override string ToString()
        {
            return "------------------------ \n Transacción: "+this.concepto+" | Cantidad: "+this.cantidad+" euros";
        }

    }
}
