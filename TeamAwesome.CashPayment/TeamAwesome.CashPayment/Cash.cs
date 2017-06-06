using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.CashPayment
{
    public class Cash
    {
        public Cash(double mygrandTotal)
        {
            grandTotal = mygrandTotal;
        }


        private double grandTotal { get; set; }

        //This is the primary method in the class. It calls the other method to keep things modularized.
        public void PayWithCash()
        {
            try
            {
                Console.WriteLine("\nYou have chosen cash payment");
                Console.WriteLine("\nHow much did the customer give you?");
                double amountTendered = Convert.ToDouble(Console.ReadLine());

                double change = CalculateChange(grandTotal, amountTendered);
                Console.WriteLine("\nCustomer's change is {0:C}", change);
                Console.WriteLine("\nTransaction Complete. Thank you!\n");

                //Ask the user what they want to do next
                Console.WriteLine("Please select [1] New Transaction or [2] Exit Program\n");
                int nextBehavior = Convert.ToInt32(Console.ReadLine());

                if (nextBehavior == 1)
                {
                    Console.Clear();
                    SubMain myNextSubMain = new SubMain();
                    myNextSubMain.SubMainMenu();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            catch(Exception myError)
            {
                //displays the error message
                Console.WriteLine(myError.Message + "\n");

                //asks user to continue transaction or cancel it
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    Console.Clear();
                    PayWithCash();
                }

                if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }
            }
           
            
        }

        public double CalculateChange(double myGrandTotal, double myTendered)
        {
            double custChange = 0;

            if (myTendered > myGrandTotal)
            {
                custChange = myTendered - myGrandTotal;
                return custChange;
            }
            else if (myTendered < myGrandTotal)
            {
                try
                {
                    double amountShort = myGrandTotal - myTendered;
                    Console.WriteLine("Please collect {0:C} from customer", amountShort);
                    Console.WriteLine("\nHow much more did the customer give you?");
                    double addedPayment = Convert.ToDouble(Console.ReadLine());
                    myTendered = myTendered + addedPayment;
                    custChange = myTendered - myGrandTotal;
                }
                catch(Exception myError)
                {
                    //displays the error message
                    Console.WriteLine(myError.Message + "\n");

                    //asks user to continue transaction or cancel it
                    Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                    char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (userDecision == 'Y')
                    {
                        double amountShort = myGrandTotal - myTendered;
                        Console.WriteLine("Please collect {0:C} from customer", amountShort);
                        Console.WriteLine("\nHow much more did the customer give you?");
                        double addedPayment = Convert.ToDouble(Console.ReadLine());
                        myTendered = myTendered + addedPayment;
                        custChange = myTendered - myGrandTotal;                        
                    }

                    if (userDecision == 'N')
                    {
                        Environment.Exit(0);
                    }
                }

                return custChange;
            }
            else
            {
                custChange = 0;
                Console.WriteLine("Exact change! Awesome!");
                return custChange;
            }
        }
    }
}
