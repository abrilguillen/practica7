using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares_atencionDeProcesos
{
    class Procedimiento
    {
        private static Random _nuevoProceso = new Random();
        private int _cicloVacio=0;
        private int _procesosRealizados;
        private int _procesoFinalizados;
        private Lista _lista = new Lista();
        public Procedimiento() { }
        public void comenzarCiclos()
        {
            for (int i = 0; i < 200; i++)
            {
                if (_nuevoProceso.Next(1, 5) == 1)
                {
                    _lista.Agregar();
                    _procesosRealizados++;
                }
                if (_lista.primero != null)
                {
                    realizarProceso();
                }
                else
                    _cicloVacio++;
            }
        }
        private void realizarProceso()
        {
            if (--_lista.primero.ciclos == 0)
            {
                _lista.eliminar();
                _procesoFinalizados++;
            }
            else
            {
                _lista.cambiarProceso();
            }
        }
        public int pRealizados()
        {
            return _procesosRealizados;
        }
        public int pFinalizados()
        {
            return _procesoFinalizados;
        }
        public int pPendientes()
        {
            return _procesosRealizados - _procesoFinalizados;
        }
        public int cPendientes()
        {
            return _lista.ciclosPendientes();
        }
        public int ciclosVacios()
        {
            return _cicloVacio;
        }
    }

}

