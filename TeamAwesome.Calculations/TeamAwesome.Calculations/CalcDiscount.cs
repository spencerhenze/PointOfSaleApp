using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.CalcCoupon;

namespace TeamAwesome.Calculations
{
    public class CalcDiscount
    {
        public CalcDiscount(double mySubtotal)
        {
            subtotal = mySubtotal;
        }


        private double subtotal { get; set; }
        private double totalDiscount { get; set; }
        private double ageDiscount { get; set; }
        private double militaryDiscount { get; set; }
        private double couponDiscount { get; set; }

        public double getDiscounts()
        {
            AgeDiscount();
            MilitaryDiscount();
            totalDiscount = ageDiscount + militaryDiscount;

            return totalDiscount;
        }

        public double AgeDiscount()
        {
            //promts user to enter customer's age
            Console.Write("\nPlease enter customer's age: ");
            int custAge = Convert.ToInt32(Console.ReadLine());

            if (custAge > 65)
            {
                ageDiscount = .15 * subtotal;
                return ageDiscount;
            }
            else
            {
                ageDiscount = 0;
                return ageDiscount;
            }

        }// end AgeDiscount

        public double MilitaryDiscount()
        {
            //asks user if the customer is a veteran
            Console.Write("\nIs the customer in or a verteran of the armed forces? [Y] or [N]: ");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                militaryDiscount = .10 * subtotal;
                return militaryDiscount;
            }
            else
            {
                militaryDiscount = 0;
                return militaryDiscount;
            }
        }// end MilitaryDiscount()
    }
}
