using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronStrategy
{
    public class CHuskySiberiano : IEstrategia
    {
        public void TiempoPaseo(double costo)
        {
            int time = 60;
            Console.WriteLine($"\nEl HUSKY SIBERIANO tiene un tiempo de paseo de: {time} minutos y cuesta RD${costo}");
        }

    }
}
