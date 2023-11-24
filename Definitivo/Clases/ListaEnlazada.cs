using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Definitivo.Clases
{
    public class ListaEnlazada
    {
        Nodo primerNodo;

        public bool ListaVacia()
        {
            return primerNodo != null ? true : false;
        }

        public void IngresarAlInicio(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            nuevoNodo._siguiente = primerNodo;
            primerNodo = nuevoNodo;
        }

        public void IngresarAlFinal(int valor)
        {
            
            Nodo nuevoNodo = new Nodo(valor);
            if(ListaVacia())
            {
                primerNodo = nuevoNodo;
                return;
            }

            Nodo nodoActual = primerNodo;
            while(nodoActual._siguiente != null)
            {
                nodoActual = nodoActual._siguiente;
            }

            nodoActual._siguiente = nuevoNodo;

        }

        public void ingresarAlMedio(int valor, Nodo siguiente)
        {
           Nodo nuevoNodo = new Nodo(valor);
           nuevoNodo._siguiente = siguiente;

           Nodo nodoAnterior = EncontrarNodoAnterior(siguiente);
           if(nodoAnterior != null)
            {
                nodoAnterior._siguiente = nuevoNodo;
            }
            else
            {
                primerNodo = nuevoNodo;
            }

        }

        private Nodo EncontrarNodoAnterior(Nodo nodo)
        {
            Nodo nodoActual = primerNodo;
            while(nodoActual != null && nodoActual._siguiente != nodo)
            {
                nodoActual = nodoActual._siguiente;

            }

            return nodoActual;

        }

        public void Ordenar()
        {
            if (ListaVacia() || primerNodo._siguiente == null)
            {
                // La lista está vacía o tiene solo un elemento, ya está ordenada
                return;
            }

            bool intercambio;
            do
            {
                intercambio = false;
                Nodo actual = primerNodo;
                Nodo anterior = null;

                while (actual._siguiente != null)
                {
                    if (actual._valor > actual._siguiente._valor)
                    {
                        // Intercambiar nodos
                        Nodo siguiente = actual._siguiente;
                        actual._siguiente = siguiente._siguiente;
                        siguiente._siguiente = actual;

                        if (anterior == null)
                        {
                            primerNodo = siguiente;
                        }
                        else
                        {
                            anterior._siguiente = siguiente;
                        }

                        intercambio = true;
                    }

                    anterior = actual;
                    actual = actual._siguiente;
                }
            } while (intercambio);
        }


    }
}
