using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_ejercicio_ed2_consola
{
    internal class Nodo
    {

        public string entrada;
        public Nodo right;
        public Nodo left;

        public string Entrada { get => entrada; set => entrada = value; }
        public Nodo Right { get => right; set => right = value; }
        public Nodo Left { get => left; set => left = value; }

        public Nodo(string entrada)
        {
            this.Entrada = entrada;
            this.Right = null;
            this.Left = null;
        }
    }
}
