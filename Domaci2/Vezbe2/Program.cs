using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;
namespace Vezbe2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Broj merenja: ");
            int brojMerenja = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donja granica opsega merenja: ");
            int donjaGranica = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Gornja granica opsega merenja: ");
            int gornjaGranica = Convert.ToInt32(Console.ReadLine());

            MeasurementGenerator mG = new MeasurementGenerator(brojMerenja, donjaGranica, gornjaGranica);

            Thread thread = new Thread(new ThreadStart(mG.GeneRator));
            thread.Start();

            thread.Join();
            //mG.mR.Display();
            mG.mR.AverageValue();
            Console.WriteLine("Unesite vrednost: ");
            mG.mR.PercentValue(Convert.ToInt32(Console.ReadLine()));
        }
        
    }
}
