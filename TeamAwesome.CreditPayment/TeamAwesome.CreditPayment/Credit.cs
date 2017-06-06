using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.CreditPayment
{
    public class Credit
    {
        public Credit(double mygrandTotal)
        {
            grandTotal = mygrandTotal;
        }

        private double grandTotal { get; set; }

        //This is the primary method in the class. It calls the other method to keep things modularized.
        public void PayWithCredit()
        {
            try
            {
                Console.WriteLine("\nYou have selected Credit Card Payment");
                Console.WriteLine("\nThe order grand total is: {0:C}. \n Please swipe card", grandTotal);
                Console.WriteLine("\n...press [Enter] when swiped...\n");
                Console.ReadLine();
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
            }
            catch (Exception myError)
            {
                //displays the error message
                Console.WriteLine(myError.Message + "\n");

                //asks user to continue transaction or cancel it
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    Console.Clear();
                    PayWithCredit();
                }

                if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }

            }
        } // end of PayWithCredit() method.
    }
}
