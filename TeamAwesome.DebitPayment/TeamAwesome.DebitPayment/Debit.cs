using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.DebitPayment
{
    public class Debit
    {
        public Debit(double mygrandTotal)
        {
            grandTotal = mygrandTotal;
        }

        private double grandTotal { get; set; }

        //This is the primary method in the class. It calls the other method to keep things modularized.
        public void PayWithDebit()
        {
            Console.WriteLine("\nYou have selected Debit Card Payment");
            Console.WriteLine("\nThe order grand total is: {0:C}. \n Please swipe card", grandTotal);
            Console.WriteLine("\n...press [Enter] when swiped...\n");
            Console.ReadLine(); // wait
            Console.WriteLine("Please enter 4-digit PIN:");
            Console.WriteLine("\n...press [Enter] when complete...\n");
            Console.ReadLine(); // wait
            Console.WriteLine("\nPayment Accepted. Transaction is complete. Thank you!\n");

            //Ask the user what they want to do next
            Console.WriteLine("Please select [1] New Transaction or [2] Exit Program\n");
            int nextBehavior = Convert.ToInt32(Console.ReadLine());

            if (nextBehavior == 1)
            {
                SubMain myNextSubMain = new SubMain();
                myNextSubMain.SubMainMenu();
            }
            else
            {
                Environment.Exit(0);
            }


        } // end of PayWithCredit() method.

    }
}
