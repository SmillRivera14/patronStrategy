using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronStrategy
{
    public class CMenu
    {
        public void Menu()
        {

            CContexto contexto = null;//Variable de referencia

            bool opcionValida = false;
            while (!opcionValida)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Elija su tipo de mascota \n[1]Husky Siberano [2] Chihuahua [3]Labrador [0]salir\n..:");
                    int opcion = int.Parse(Console.ReadLine());

                    if (opcion == 1)
                    {
                        CHuskySiberiano HUSKYSIBERIANO = new CHuskySiberiano();
                        contexto = new CContexto(HUSKYSIBERIANO);//Objeto
                        contexto.Ejecutar(300);
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else if (opcion == 2)
                    {
                        CCHIHUAHUA CHIHUAHUA = new CCHIHUAHUA();
                        contexto = new CContexto(CHIHUAHUA);
                        contexto.Ejecutar(100);
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();

                    }
                    else if (opcion == 3)
                    {
                        CLABRADOR LABRADOR = new CLABRADOR();
                        contexto = new CContexto(LABRADOR);
                        contexto.Ejecutar(200);
                        Console.Write("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();

                    }
                    else if (opcion == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Gracias por utilizar el programa");
                        opcionValida = true;

                    }else 
                    {
                        Console.WriteLine($"\nEl número debe coincidir con los indicados, {opcion} no coincide");
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                }

                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("La entrada debe ser un número entero.");
                    Console.Write("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
