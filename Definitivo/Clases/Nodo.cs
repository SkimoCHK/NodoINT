using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Definitivo.Clases
{
    public class Nodo
    {

        private int Valor;
        private Nodo Siguiente;

        public int _valor;
        public Nodo _siguiente;


        //Metodo pa ingresar un nodo al inicio o al final
        public Nodo (int valor)
        {
            _valor = valor;
            _siguiente = null;

        }
        
        //Constructor pa ingresar valor en el medio
        public Nodo (int valor, Nodo siguiente)
        {
            _valor = valor;
            _siguiente = siguiente;
        }

    }
}
