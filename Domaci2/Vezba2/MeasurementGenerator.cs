using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Vezba2
{
    class MeasurementGenerator
    {
        int num_of_measurements;
        int[] scope;
        public Recorder r;

        //ne isplati se praviti listu, jer koristi previse memorije,
        //lakse je poslati dva parametra tipa int(*isplatljivije!*), nego igrati se ovako sa listom :)
        public MeasurementGenerator(int num_of_measurements, int[] scope)
        {
            this.num_of_measurements = num_of_measurements;
            this.scope = scope;
            this.r = new Recorder();
        }

        public void ThreadGenerator()
        {
            Random random = new Random();
            for (int i = 0; i < this.num_of_measurements; i++)
            {
                this.r.Record(new Measurement(i, random.Next(this.scope[0], this.scope[1]), DateTime.Now));
                //this.r.DisplayOne(i);
                Thread.Sleep(1000);
            }
        }
    }
}
