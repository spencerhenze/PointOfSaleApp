using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAwesome.Calculations
{
    public class CalcSubtotal
    {
        public double runningSubtotal = 0;


        public double AddCost(double myItemTotal)
        {
            runningSubtotal = runningSubtotal + myItemTotal;
            return runningSubtotal;

        }
        public void ClearSubtotal()
        {
            runningSubtotal = 0;
        }

    }
}
