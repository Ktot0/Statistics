using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_EX1
{
    internal class RPoint
    {
        public double X;
        public double Y;

        public RPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X.ToString() + " - " + Y.ToString();
        }
    }
}
