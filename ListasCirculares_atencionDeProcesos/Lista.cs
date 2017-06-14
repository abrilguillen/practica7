using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares_atencionDeProcesos
{
    class Lista
    {
        private static Random cantCiclos = new Random();
        private Proceso _primero;
        public Proceso primero { get { return _primero; } }
        public Lista() { }
        public void Agregar()
        {
            if (_primero == null)
            {
                _primero = new Proceso(cantCiclos.Next(4, 13));
                _primero.anterior = _primero;
                _primero.siguiente = _primero;
            }
            else
            {
                Proceso proceso1 = new Proceso(cantCiclos.Next(4, 13));
                _primero.anterior.siguiente = proceso1;
                proceso1.anterior = _primero.anterior;
                proceso1.siguiente = _primero;
                _primero.anterior = proceso1;
            }
        }
        public void eliminar()
        {
            if (_primero.siguiente== _primero && _primero.anterior == primero)
            {
                _primero = null;
            }
            else
            {
                _primero.anterior.siguiente = _primero.siguiente;
                _primero.siguiente.anterior = _primero.anterior;
                _primero = _primero.siguiente;
            }
        }
        public void cambiarProceso()
        {
            _primero = _primero.siguiente;
        }
        public int ciclosPendientes()
        {
            if (primero != null)
            
                return ciclosPendientes(_primero);
            else 
                
                    return 0;
                
            
        }
        private int ciclosPendientes(Proceso ultimo)
        {
            if (ultimo.siguiente != _primero)
                return ultimo.ciclos + ciclosPendientes(ultimo.siguiente);
            else
            {
                return ultimo.ciclos;
            }
        }
    }
}
