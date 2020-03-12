using System;
using System.Collections.Generic;
using System.Text;

namespace CuentaBanco
{
    public class Cliente
    {
        private string nombre;
        private List<Transaction> transacciones;

        public Cliente(string n)
        {
            this.nombre = n;
            transacciones = new List<Transaction>();
        }

        public Cliente(string n, List<Transaction> l)
        {
            this.nombre = n;
            this.transacciones = l;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public List<Transaction> GetTransacciones()
        {
            return this.transacciones;
        }

        public void AddTransaction(Transaction t)
        {
            this.transacciones.Add(t);
        }

        public override string ToString()
        {
            return "Cliente: "+this.nombre;
        }

        public void MostrarTransacciones()
        {
            foreach(Transaction t in transacciones)
            {
                Console.WriteLine(t.ToString());
            }
        }

    }
}
