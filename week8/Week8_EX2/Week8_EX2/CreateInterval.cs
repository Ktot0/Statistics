﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_EX2
{
    internal class CreateInterval : IComparable<CreateInterval>
    {
        public double up;
        public double down;

        public CreateInterval(double down, double up)
        {
            this.up = up;
            this.down = down;
        }

        public override string ToString()
        {
            return down.ToString() + " - " + up.ToString();
        }

        public int CompareTo(CreateInterval other)
        {
            if (other == null)
                throw new Exception("Error: Null Interval");
            if (this.down == other.down && this.up == other.up)
                return 0;
            else if (this.up <= other.down)
                return -1;
            else if (this.down >= other.up)
                return 1;
            else
                throw new Exception("Error: Intervals intersect");

        }
    }
}
