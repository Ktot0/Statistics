using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_EX1
{
    public class sample
    {
        double height;
        int quantity;

        public sample() { }

        public sample(double height, int quantity)
        {
            this.height = height;
            this.quantity = quantity;
        }

        public void setHeight(double h)
        {
            this.height = h;
        }

        public double getHeight()
        {
            return this.height;
        }

        public int getQuantity()
        {
            return this.quantity;
        }

    }
}
