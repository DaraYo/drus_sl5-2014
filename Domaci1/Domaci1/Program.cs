using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci1
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter c = new Converter();
            double option=100;
            while (option!= 0) 
            {
                Console.WriteLine("Opcije:");
                Console.WriteLine("1. Konverzija iz celzijusa u farenhajte");
                Console.WriteLine("2. Konverzija iz farenhajta u celzijuse");
                Console.WriteLine("0. Izlaz iz programa");
                Console.Write("Unesite broj:");
                try
                {
                    option = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    option = 200;
                }
                if (option == 1)
                {
                    Console.Clear();
                    c.From_c_to_f();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    c.From_f_to_c();
                }
                else if(option!=0)
                {
                    Console.WriteLine("Pogresan unos, pokusajte ponovo!");
                }

            }
            




        }
    }
}
