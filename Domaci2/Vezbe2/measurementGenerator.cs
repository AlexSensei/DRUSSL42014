using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Vezbe2
{
    class MeasurementGenerator
    {
        int brojMerenja;
        int donjaGranica;
        int gornjaGranica;
        public MeasurementRecorder mR;
        public MeasurementGenerator(int bM, int oM, int om)
        {
            this.brojMerenja = bM;
            this.donjaGranica = oM;
            this.gornjaGranica = om;
            this.mR = new MeasurementRecorder();
        }
        public void GeneRator()
        { 
            Random random = new Random();
            for (int i = 0; i < this.brojMerenja; i++)
            {
                Double value = random.Next(this.donjaGranica,this.gornjaGranica);
                this.mR.Record(new Measurement(i, value, DateTime.Now));

                Thread.Sleep(1000);
            }
        }
    }
}
