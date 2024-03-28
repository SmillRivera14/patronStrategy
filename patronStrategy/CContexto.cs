using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronStrategy
{
    class CContexto
    {
        IEstrategia Estrategia;
        public CContexto(IEstrategia objeto)
        {
            this.Estrategia = objeto;
        }

        public void Ejecutar (double valor) {
        
            Estrategia.TiempoPaseo (valor);
        }
    }
}
