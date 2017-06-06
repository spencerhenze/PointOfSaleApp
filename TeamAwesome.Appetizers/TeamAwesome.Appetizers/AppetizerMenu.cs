using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.Appetizers
{
    public class AppetizerMenu
    {
        public int ListOfAppetizers()
        {
            //declare a variable
            int myAppetizerSelection = 0;

            try
            {
                //display list of food specialties and other options
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select the appetizer(s) from the following:");
                Console.WriteLine("[1] Onion Rings                  $5.00");
                Console.WriteLine("[2] Buffalo Wings                $8.00");
                Console.WriteLine("[3] Rocky Mountain Oysters       $10.00");
                Console.WriteLine("[4] Back to Main Menu\n");

                //promts user to enter the selection
                Console.Write("Enter selection: ");
            }
            catch (Exception myError)
            {
                Console.WriteLine(myError.Message + "\n");
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    Console.Clear();
                    AddAppetizer();
                }

                if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }
            }
            return myAppetizerSelection = Convert.ToInt32(Console.ReadLine());

        } //enf of ListOfAppetizers property


        public double AddAppetizer()
        {

            //declare variables
            int customerAppetizerSelection = 0, quantity;
            double totalAmountAppetizer = 0;

            customerAppetizerSelection = ListOfAppetizers();

            switch (customerAppetizerSelection)
            {
                case 1:
                    try
                    {
                        double onionRingsPrice = 5;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate segment subtotal 
                        totalAmountAppetizer = onionRingsPrice * quantity;
                        Console.WriteLine("Total amount for Onion Rings is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                        //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                        return totalAmountAppetizer;
                        //returns the total amount and breaks back to the main menu

                    }
                    catch (Exception myError)
                    {
                        Console.WriteLine(myError.Message + "\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double onionRingsPrice = 5;
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate segment subtotal 
                            totalAmountAppetizer = onionRingsPrice * quantity;
                            Console.WriteLine("Total amount for Onion Rings is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                            //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                            return totalAmountAppetizer;
                        }

                        if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }

                    }

                    break;
                case 2:
                    try
                    {
                        double buffaloWingsPrice = 8;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate segment subtotal 
                        totalAmountAppetizer = buffaloWingsPrice * quantity;
                        Console.WriteLine("Total amount for Buffalo Wings is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                        //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                        return totalAmountAppetizer;
                        //returns the total amount and breaks back to the main menu

                        //show specialty menu to add an order or go back to the main menu
                    }
                    catch (Exception myError)
                    {
                        Console.WriteLine(myError.Message + "\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double buffaloWingsPrice = 8;
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate segment subtotal 
                            totalAmountAppetizer = buffaloWingsPrice * quantity;
                            Console.WriteLine("Total amount for Buffalo Wings is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                            //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                            return totalAmountAppetizer;
                        }

                        if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }
                    }
                    break;
                case 3:
                    try
                    {
                        double rMOystersPrice = 10.00;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate RM Oysters item total
                        totalAmountAppetizer = rMOystersPrice * quantity;
                        Console.WriteLine("Total Amount for Rocky Mountain Oysters is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                        //return totalAmountSpecialty to subMainMenu
                        return totalAmountAppetizer;
                    }
                    catch (Exception myError)
                    {
                        Console.WriteLine(myError.Message + "\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double rMOystersPrice = 10.00;
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate RM Oysters item total
                            totalAmountAppetizer = rMOystersPrice * quantity;
                            Console.WriteLine("Total Amount for Rocky Mountain Oysters is " + "{0:C2}", +totalAmountAppetizer + ".\n");

                            //return totalAmountSpecialty to subMainMenu
                            return totalAmountAppetizer;
                        }

                        if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }
                    }
                    break;
                case 4:
                    try
                    {
                        totalAmountAppetizer = 0;
                        Console.WriteLine("\nProcess cancelled. Returning to Main Menu.");
                        return totalAmountAppetizer;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }

            return totalAmountAppetizer;
        } // end of AddAppetizer() method



    }
}
