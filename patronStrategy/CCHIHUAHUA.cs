using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronStrategy
{
    public class CCHIHUAHUA : IEstrategia
    {
        public void TiempoPaseo(double costo)
        {
           int time = 20;
            Console.WriteLine($"\nEl Chihuahua tiene un tiempo de paseo de: {time} minutos y cuesta RD${costo}");
        }
    }
}
