using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domaci
{
    class TemperatureConvertor
    {
        public double tmp;
        public double Tmp
        {
            get { return tmp; }
            private set { Tmp = value; }
        }

        public TemperatureConvertor(double tmp)
        {
            this.tmp = tmp;
        }

        public double FarenToCelsius()
        {

            tmp = (tmp - 32) / 1.8;
            return tmp;
        }
        public double CelsiusToFaren()
        {
            tmp = tmp * 9 / 5 + 32;
            return tmp;
        }
    }
}
