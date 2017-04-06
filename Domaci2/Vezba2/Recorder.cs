using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vezba2
{
    class Recorder
    {
        private Dictionary<int, Measurement> Measurements { get; set; }
        public Recorder()
        {
            this.Measurements = new Dictionary<int, Measurement>();
        }

        public void Record(Measurement measurement)
        {
            var key = measurement.Id;
            this.Measurements[key] = measurement;
            Console.WriteLine("Measurement[{0}]= {1}", measurement.Id, measurement.Value);
        }

        public void Display()
        {
            foreach (var item in this.Measurements)
            {
                Console.WriteLine("Measurement[{0}]= {1}", item.Key, item.Value);
            }
        }

        public void DisplayOne(int i)
        {
            Console.WriteLine(this.Measurements[i]);
        }

        public void Average()
        {
            double sum= 0;
            for (int i = 0; i < this.Measurements.Count; i++)
            {
                sum += this.Measurements[i].Value;
            }
            Console.WriteLine("Average value of measurements is {0}", sum / this.Measurements.Count);
        }

        public void Percentage_of_measurments(int number)
        {
            int count= 0;
            foreach (var element in this.Measurements)
            {
                if (element.Value.Value < number)
                {
                    count++;
                }
            }
            double value = count * 100 / this.Measurements.Count;
            Console.WriteLine("Under: {0}",value);
            Console.WriteLine("Above: {0}", 100 - value);

        }
    }
}
