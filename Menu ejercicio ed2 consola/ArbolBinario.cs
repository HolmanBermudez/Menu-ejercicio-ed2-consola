using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_ejercicio_ed2_consola
{
    internal class ArbolBinario
    {
        public Nodo Raiz;

        public ArbolBinario()
        {
            Raiz = null;
        }

        public void Insertar( Nodo raiz, string entrada)
        {
            Insertarreg( raiz, entrada);

        }
        public Nodo Insertarreg( Nodo raiz, string entrada)
        {
            if (raiz == null)
            {
                raiz = new Nodo(entrada);
                return raiz;
            }
            if (string.Compare(entrada, raiz.Entrada) < 0)
            {
                Raiz.left=Insertarreg( raiz.left, entrada);
            }
            else if (string.Compare(entrada, raiz.Entrada) > 0)
            {
                Raiz.right=Insertarreg( raiz.right, entrada);
            }
            return raiz;

        }
        public Nodo Buscar(Nodo inicio, string dato)
        {
            if (inicio == null)
            {
                return inicio;
            }
            if (string.Compare(dato, inicio.entrada) > 0)
            {
                return Buscar(inicio.right, dato);
            }
            if (string.Compare(dato, inicio.entrada) < 0)
            {
                return Buscar(inicio.left, dato);
            }
            return inicio;
        }
        public void PrintInOrder(Nodo raiz)
        {
            if (raiz == null)
            {
                PrintInOrder(raiz.left);
                Console.WriteLine($" entrada:{raiz.Entrada}");
                PrintInOrder(raiz.right);
            }
        }
        public void PrintPreOrden(Nodo raiz)
        {
            if (raiz == null)
            {
                Console.WriteLine($"entrada:{raiz.Entrada}");
                PrintPreOrden(raiz.left);
                PrintPreOrden(raiz.right);
            }
        }
        public void PrintPosOrden(Nodo raiz)
        {
            if (raiz == null)
            {
                PrintPreOrden(raiz.left);
                PrintPreOrden(raiz.right);
                Console.WriteLine($"entrada:{raiz.Entrada}");

            }
        }
    }
}
