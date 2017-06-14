using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares_atencionDeProcesos
{
    class Proceso
    {
        private int _ciclos;
        private Proceso _siguiente;
        private Proceso _anterior;
       
        public int ciclos
        {
            get { return _ciclos; }
            set { _ciclos = value; }
        }
        public Proceso anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }
        public Proceso siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public Proceso(int ciclos)
        {
            _ciclos = ciclos;
        }

    }
}
