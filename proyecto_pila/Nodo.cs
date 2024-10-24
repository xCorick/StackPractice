using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    public class Nodo
    {
        private double valor;
        private Nodo sig;

        public double Valor { get => valor; set => valor = value; }
        internal Nodo Sig { get => sig; set => sig = value; }

        public Nodo(double valor)
        {
            Valor = valor;
            Sig = null;
        }
    }
}
