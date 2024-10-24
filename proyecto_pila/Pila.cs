using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Pila
    {
        private int max;
        private int tope = 0;
        private Nodo inicio;

        public int Max { get => max; set => max = value; }
        public int Tope { get => tope; set => tope = value; }
        public Nodo Inicio { get => inicio; set => inicio = value; }

        public Pila(int max)
        {
            Max = max;
            inicio = null;
        }

        public bool Empty()
        {
            if (Inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Full()
        {
            if (Tope == Max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintStack()
        {
            //imprime la pila
        }

        public bool Push(double num)
        {
            return true;
            //regresa true si la insercion es exitosa
            //else da false si la pila esta llena y no se inserto
        }

        public double Pop()
        {
            return 69;
            //regresa el numero sacado de la pila
            //si la pila esta vacia regresa -1
        }
    }
}
