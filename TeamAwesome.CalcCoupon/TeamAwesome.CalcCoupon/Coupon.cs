using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAwesome.CalcCoupon
{
    public class Coupon
    {

        public Coupon(double myTotal)
        {
            total = myTotal;
        }
        //declare variables 
        private double total { get; set; }
        private double flatCoupon { get; set; }

        private double percentCoupon { get; set; }

        private double savings { get; set; }
        private double totalDiscount { get; set; }

        public double GetCoupon()
        {
            Console.WriteLine("\nDoes the customer have a coupon? [Y] or [N]\n");
            string couponResponse = Console.ReadLine().ToUpper();
            if (couponResponse == "Y")
            {

                Console.WriteLine("Enter [F] for flat Coupon or [P] for percent coupon");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "F")
                {
                    totalDiscount = FlatCoupon();

                }

                else if (answer == "P")
                {
                    totalDiscount = PercentCoupon();
                }

                else
                {
                    totalDiscount = 0;
                }

            }
            else if (couponResponse == "N")
            {
                totalDiscount = 0;
            }


            return totalDiscount;
        }


        public double FlatCoupon()
        {
            if(total > 50)
            {
                savings = 6;
                Console.WriteLine("\nCoupon discount = {0:C}", savings);
                return savings;
            }// end of if statement

            else if(total > 25)
            {
                savings = 3;
                Console.WriteLine("\nCoupon discount = {0:C}", savings);
                return savings;
            }

            else
            {
                savings = 0;
                Console.WriteLine("\nOrder total is too low to use the coupon. Must be $25 or higher");
                return savings;
            }//end of else statement
        }//end of flatcoupon method

        public double PercentCoupon()
        {
            if(total >25)
            {
                savings = total * .11;
                Console.WriteLine("\n11% discount = {0:C}", savings);

                return savings;
            }

            else
            {
                savings = 0;
                Console.WriteLine("\nOrder total is too low to use the coupon. Must be $25 or higher");

                return savings;
            }
        }//end of percent coupon



    }
}
