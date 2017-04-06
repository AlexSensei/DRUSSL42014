using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe2
{
    class Measurement
    {
        public int ID { get; private set; }
        public double Value { get; private set; }
        public DateTime timeStamp { get; private set; }
        public Measurement(int ID,double V,DateTime tS)
        {
            this.ID = ID;
            this.Value = V;
            this.timeStamp = tS;
        }
        public override string ToString()
        {
            return String.Format("{0} measurement's  value is {1} , measured at {2}", this.ID,this.Value,this.timeStamp);
        }
    }
}
