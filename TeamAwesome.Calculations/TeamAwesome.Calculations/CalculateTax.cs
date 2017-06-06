using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAwesome.Calculations
{
    public class CalculateTax
    {
        //declare variable(s)
        private double taxRate = 0.07;

        public double CalcTax(double myOrderSubtotal)
        {
            double orderTax = myOrderSubtotal * taxRate;
            return orderTax;

        }
    }
}
