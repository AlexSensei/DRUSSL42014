using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbe2
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public Point(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("Vrednosti su {0} i {1} ", x, y);
        }
    }
}
