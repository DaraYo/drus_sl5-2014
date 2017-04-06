using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Vezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scope= new int[2];
            Console.WriteLine("Insert number of measurements: ");
            int numb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert scope values for generating measurements: ");
            scope[0] = Convert.ToInt32(Console.ReadLine());
            scope[1] = Convert.ToInt32(Console.ReadLine());

            MeasurementGenerator mg= new MeasurementGenerator(numb, scope);
            Thread t = new Thread(new ThreadStart(mg.ThreadGenerator));
            t.Start();
            t.Join();

            mg.r.Average();
            Console.WriteLine("Insert value for percentage of all measurements under and above it: ");
            int number = Convert.ToInt32(Console.ReadLine());
            mg.r.Percentage_of_measurments(number);
            
            Console.ReadKey();
        }
    }

}
