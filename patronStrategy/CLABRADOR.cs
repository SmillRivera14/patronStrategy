using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronStrategy
{
    public class CLABRADOR : IEstrategia
    {
        public void TiempoPaseo(double costo)
        {
            int time = 40;
            Console.WriteLine($"\nEl lABRADOR tiene un tiempo de paseo de: {time} minutos y cuesta RD${costo}");
        }
    }
}
