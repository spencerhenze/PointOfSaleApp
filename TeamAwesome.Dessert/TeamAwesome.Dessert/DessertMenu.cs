using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.Dessert
{
    public class DessertMenu
    {
        public int ListofDesserts()
        {
            //declare a variable
            int myDessertSelection = 0;

            try
            {
                //display list of food specialties and other options
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select Dessert from the following:");
                Console.WriteLine("[1] Vanilla Cone          $1.00");
                Console.WriteLine("[2] Brownies              $2.50");
                Console.WriteLine("[3] Chocolate Cake        $3.50");
                Console.WriteLine("[4] Back to Main Menu\n");

                //promts user to enter the selection
                Console.Write("Enter selection: ");
                myDessertSelection = Convert.ToInt32(Console.ReadLine());
            } //end of first try

            catch (Exception myError)
            {
                //shows error message if user enters wrong data type
                Console.WriteLine(myError.Message + "\n");

                //asks user to continue or cancel the application
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    AddDessert();
                }

                else if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }

                else if (userDecision != 'Y' || userDecision != 'N')
                {
                    Console.WriteLine(myError.Message + "\n");

                    do
                    {
                        Console.WriteLine("\n");
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision2 == 'Y')
                        {

                            AddDessert();
                        }

                        else if (userDecision2 == 'N')
                        {
                            Environment.Exit(0);
                        }
                    } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                }

            } //end of first catch    

            return myDessertSelection;
        } //end of ListOfSpecialities property


        public double AddDessert()
        {

            //declare variables
            int customerDessertSelection = 0, quantityDessert;
            double totalAmountDessert = 0;

            customerDessertSelection = ListofDesserts();

            //begin process using a switch-case method inside a do-while loop
            switch (customerDessertSelection)
            {
                //VannillaCone 
                case 1:
                    try
                    {
                        double vannillaCone = 1;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantityDessert = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays  segment subtotal 
                        totalAmountDessert = vannillaCone * quantityDessert;
                        Console.WriteLine("Total amount for Vannilla Cone(s) is {0:C2}\n", totalAmountDessert);

                        /*not doing this here [pass totalAmountSpecialty value to another class for calculation]
                        since we want only 1 calcualtion object to calculate the running total, we will have this 
                        entire method simply return a value that will be passed to the calculation class by the subMain class.
                        show specialty menu to add an order or go back to the main menu*/

                        return totalAmountDessert;

                    }
                    catch (Exception myError)
                    {
                        //shows error message if user enters wrong data type
                        Console.WriteLine(myError.Message + "\n");

                        //asks user to continue or cancel the application
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double vannillaCone = 1;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                           quantityDessert = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays  segment subtotal 
                            totalAmountDessert = vannillaCone * quantityDessert;
                            Console.WriteLine("Total amount for Vannilla Cone(s) is {0:C2}\n", totalAmountDessert);

                            return totalAmountDessert;
                        }

                        else if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }

                        else if (userDecision != 'Y' || userDecision != 'N')
                        {
                            Console.WriteLine(myError.Message + "\n");

                            do
                            {
                                Console.WriteLine("\n");
                                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                                char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());

                                if (userDecision2 == 'Y')
                                {
                                    double vannillaCone = 1;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantityDessert = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays  segment subtotal 
                                    totalAmountDessert = vannillaCone * quantityDessert;
                                    Console.WriteLine("Total amount for the Vannilla Cone(s) is {0:C2}\n", totalAmountDessert);

                                    return totalAmountDessert;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }
                    break;

                //Brownie
                case 2:

                    try
                    {
                        double smBrownies = 2.50;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantityDessert = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays segment subtotal 
                        totalAmountDessert =smBrownies * quantityDessert;
                        Console.WriteLine("Total amount for Brownie(s) is {0:C2}\n", totalAmountDessert);

                        return totalAmountDessert;

                    }
                    catch (Exception myError)
                    {
                        //shows error message if user enters wrong data type
                        Console.WriteLine(myError.Message + "\n");

                        //asks user to continue or cancel the application
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double smBrownies = 1.75;
                            //promts user to enter quantity
                            Console.Write("Enter quantity: ");
                            quantityDessert = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays  segment subtotal 
                            totalAmountDessert = smBrownies * quantityDessert;
                            Console.WriteLine("Total amount for Brownie(s) is {0:C2}\n", totalAmountDessert);

                            return totalAmountDessert;

                        }

                        else if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }

                        else if (userDecision != 'Y' || userDecision != 'N')
                        {
                            Console.WriteLine(myError.Message + "\n");

                            do
                            {
                                Console.WriteLine("\n");
                                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                                char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());

                                if (userDecision2 == 'Y')
                                {
                                    double smBrownies = 2.50;

                                    //promts user to enter quantity
                                    Console.Write("Enter quantity: ");
                                    quantityDessert = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays  segment subtotal 
                                    totalAmountDessert = smBrownies * quantityDessert;
                                    Console.WriteLine("Total amount for the Brownie(s) is {0:C2}\n", totalAmountDessert);

                                    return totalAmountDessert;

                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }

                    break;

                //ChocolateCake
                case 3:

                    try
                    {
                        double chocolateCake = 3.50;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantityDessert = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays  segment subtotal 
                        totalAmountDessert = chocolateCake * quantityDessert;
                        Console.WriteLine("Total amount for Chocolate Cake is {0:C2}\n", totalAmountDessert);

                        return totalAmountDessert;

                    }
                    catch (Exception myError)
                    {
                        //shows error message if user enters wrong data type
                        Console.WriteLine(myError.Message + "\n");

                        //asks user to continue or cancel the application
                        Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                        char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision == 'Y')
                        {
                            double chocolateCake = 3.50;

                            //promts user to enter quantity
                            Console.Write("Enter quantity: ");
                            quantityDessert = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays  segment subtotal 
                            totalAmountDessert = chocolateCake * quantityDessert;
                            Console.WriteLine("Total amount for Chocolate Cake  is {0:C2}\n", totalAmountDessert);
                            return totalAmountDessert;
                        }

                        else if (userDecision == 'N')
                        {
                            Environment.Exit(0);
                        }

                        else if (userDecision != 'Y' || userDecision != 'N')
                        {
                            Console.WriteLine(myError.Message + "\n");

                            do
                            {
                                Console.WriteLine("\n");
                                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                                char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());

                                if (userDecision2 == 'Y')
                                {
                                    double chocolateCake = 3.50;

                                    //promts user to enter quantity
                                    Console.Write("Enter quantity: ");
                                    quantityDessert = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays  segment subtotal 
                                    totalAmountDessert = chocolateCake * quantityDessert;
                                    Console.WriteLine("Total amount for Chocolate Cake is {0:C2}\n", totalAmountDessert);

                                    return totalAmountDessert;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }

                    break;

                //allows user to go back to the Main Menu
                case 4:
                    try
                    {
                        totalAmountDessert = 0;
                        Console.WriteLine("\nProcess cancelled. Returning to Main Menu.");
                        return totalAmountDessert;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }

            return totalAmountDessert;
        }
    } // end of dessert class


}

