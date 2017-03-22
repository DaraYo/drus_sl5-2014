using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci1
{
    class Converter
    {
        //f = c *9/5+32
        //c=(f-32)/(9/5)
        private double degree;

	    public double Degree
	    {
		    get { return degree;}
		    private set { degree = value;}
	    }

        public Converter ()
	    {
                
	    }

        public void From_c_to_f()
        {
            string option="";
            while (!option.Equals("q"))
            {
                try
                {
                    Console.WriteLine("Ako zelite da se vratite na glavni meni, unesite q");
                    Console.Write("Stepeni u celzijusima>>");
                    option = Console.ReadLine();
                    degree = (Convert.ToDouble(option)*1.8) + 32;
                    Console.WriteLine("Stepeni u farenhajtima iznose: " + degree);
                }
                catch
                {
                    if(!option.Equals("q"))
                        Console.WriteLine("Pogresan unos, moracete ponovo!");
                }
            }
            Console.Clear();
        }

        public void From_f_to_c()
        {
            string option = "";
            while (!option.Equals("q"))
            {
                try
                {
                    Console.WriteLine("Ako zelite da se vratite na glavni meni, unesite q");
                    Console.Write("Stepeni u farenhajtima>>");
                    option = Console.ReadLine();
                    degree = (Convert.ToDouble(option) - 32) / 1.8;
                    Console.WriteLine("Stepeni u celzijusima iznose: " + degree);
                }
                catch (Exception e)
                {
                    if (!option.Equals("q"))
                        Console.WriteLine("Pogresan unos, moracete ponovo!");
                }
            }
            Console.Clear();
        }
    }
}
