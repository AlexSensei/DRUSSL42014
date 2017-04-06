using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe2
{
    class MeasurementRecorder
    {
        public Dictionary<int,Measurement> measurements { get; set; }
        public MeasurementRecorder()
        {
            this.measurements = new Dictionary<int, Measurement>();
        }
        public void Record(Measurement measurement)
        {
            this.measurements[measurement.ID] = measurement;
            Console.WriteLine("Value at key {0} is {1}.", measurement.ID, measurement.Value);
        }
        public void Display()
        {
            foreach (var element in this.measurements)
            {
                Console.WriteLine("Value at key {0} is {1}.", element.Key, element.Value);
            }
        }
        public void AverageValue()
        {
            double sum=0;
            int count=0;
            foreach(var element in this.measurements)
            {
                sum = sum + this.measurements[count].Value;
                count++;
            }
            Console.WriteLine("Srednja vrednost svih merenja je {0}, a merenja ima {1}", sum/count, count);
        }
        public void PercentValue(int v)
        {
            float pvalue;
            int count=0;
            foreach(var element in this.measurements)
            {
                if (this.measurements[element.Key].Value > v)
                    count++;
            }

            pvalue = (100 * count) / this.measurements.Count;

            Console.WriteLine("{0}% vrednosti se nalazi iznad unete temperature, a {1}% vrednosti ispod", pvalue,100-pvalue);
        }
    }
}
