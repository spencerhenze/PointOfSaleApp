using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.Combos
{
    public class ComboMenu
    {
        public int ListOfCombos()
        {
            //declare a variable
            int myComboSelection = 0;

            try
            {
                //display list of food specialties and other options
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select the appetizer(s) from the following:");
                Console.WriteLine("[1] Pizza, 2 Sodas                                  $14.00");
                Console.WriteLine("[2] Onion Rings, Vegan Pizza, 3 Sodas               $11.00");
                Console.WriteLine("[3] Rocky Mountain Oysters, Spicy Pizza, 4 Sodas    $10.00");
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
                    AddCombo();
                }

                if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }
            }
            return myComboSelection = Convert.ToInt32(Console.ReadLine());

        } //enf of ListOfAppetizers property


        public double AddCombo()
        {

            //declare variables
            int customerComboSelection = 0, quantity;
            double totalAmountCombo = 0;

            customerComboSelection = ListOfCombos();

            switch (customerComboSelection)
            {
                case 1:
                    try
                    {
                        double combo1Price = 14;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate segment subtotal 
                        totalAmountCombo = combo1Price * quantity;
                        Console.WriteLine("Total amount for Combo 1 is " + "{0:C2}", +totalAmountCombo + ".\n");

                        //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                        return totalAmountCombo;
                        //returns the total amount and breaks back to the main menu

                    }
                    catch (Exception myError)
                    {
                        Console.WriteLine(myError.Message + "\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double combo1Price = 14;
                            Console.Write("Enter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate segment subtotal 
                            totalAmountCombo = combo1Price * quantity;
                            Console.WriteLine("Total amount for Combo 1 is " + "{0:C2}", +totalAmountCombo + ".\n");

                            //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                            return totalAmountCombo;
                            //returns the total amount and breaks back to the main menu
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
                        double combo2Price = 11;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate segment subtotal 
                        totalAmountCombo = combo2Price * quantity;
                        Console.WriteLine("Total amount for Buffalo Wings is " + "{0:C2}", +totalAmountCombo + ".\n");

                        //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                        return totalAmountCombo;
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
                            double combo2Price = 11;
                            Console.Write("Enter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate segment subtotal 
                            totalAmountCombo = combo2Price * quantity;
                            Console.WriteLine("Total amount for Buffalo Wings is " + "{0:C2}", +totalAmountCombo + ".\n");

                            //since we want only 1 calcualtion object to calculate the running total, we will have this entire method simply return a value that will be passed to the calculation class by the subMain class.
                            return totalAmountCombo;
                            //returns the total amount and breaks back to the main menu
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
                        double combo3Price = 10.00;
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate RM Oysters item total
                        totalAmountCombo = combo3Price * quantity;
                        Console.WriteLine("Total Amount for Rocky Mountain Oysters is " + "{0:C2}", +totalAmountCombo + ".\n");

                        //return totalAmountSpecialty to subMainMenu
                        return totalAmountCombo;
                    }
                    catch (Exception myError)
                    {
                        Console.WriteLine(myError.Message + "\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double combo3Price = 10.00;
                            Console.Write("Enter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate RM Oysters item total
                            totalAmountCombo = combo3Price * quantity;
                            Console.WriteLine("Total Amount for Rocky Mountain Oysters is " + "{0:C2}", +totalAmountCombo + ".\n");

                            //return totalAmountSpecialty to subMainMenu
                            return totalAmountCombo;
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
                        totalAmountCombo = 0;
                        Console.WriteLine("\nProcess cancelled. Returning to Main Menu.");
                        return totalAmountCombo;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }

            return totalAmountCombo;
        } // end of AddAppetizer() method





    }
}
