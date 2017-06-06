using System;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.FoodSpecialty
{
    public class SpecialtyMenu
    {

        public int ListOfSpecialties()
        {
            //declare a variable
            int mySpecialtySelection = 0;
                 
            try
            {
                //display list of food specialties and other options
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select food specialty from the following:");
                Console.WriteLine("[1] TA's Jumbo Size Pizza - $12.00");
                Console.WriteLine("[2] TA's Vegan Pizza      - $8.00");
                Console.WriteLine("[3] TA's Spicy Pizza      - $8.00");
                Console.WriteLine("[4] Back to Main Menu\n");

                //promts user to enter the selection
                Console.Write("Enter selection: ");
                mySpecialtySelection = Convert.ToInt32(Console.ReadLine());
            } //end of first try

            catch(Exception myError)
            {
                //shows error message if user enters wrong data type
                Console.WriteLine(myError.Message + "\n");

                //asks user to continue or cancel the application
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    AddSpecialty();
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
                           
                            AddSpecialty();
                        }

                        else if (userDecision2 == 'N')
                        {
                            Environment.Exit(0);
                        }
                    } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop
                                       
                }

            } //end of first catch    

            return mySpecialtySelection;        
        } //end of ListOfSpecialities property


        public double AddSpecialty()
        {
           
            //declare variables
            int customerSpecialtySelection = 0, quantitySpecialty;
            double totalAmountSpecialty = 0;
        
            customerSpecialtySelection = ListOfSpecialties();

            //begin process using a switch-case method inside a do-while loop
                switch (customerSpecialtySelection)
                {
                    //Jumbo Pizza Specialty
                    case 1:
                    try
                    {
                        double jumboPizzaSpecialty = 12;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays jumbo pizza segment subtotal 
                        totalAmountSpecialty = jumboPizzaSpecialty * quantitySpecialty;
                        Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                        /*not doing this here [pass totalAmountSpecialty value to another class for calculation]
                        since we want only 1 calcualtion object to calculate the running total, we will have this 
                        entire method simply return a value that will be passed to the calculation class by the subMain class.
                        show specialty menu to add an order or go back to the main menu*/

                        return totalAmountSpecialty;

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
                            double jumboPizzaSpecialty = 12;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays jumbo pizza segment subtotal 
                            totalAmountSpecialty = jumboPizzaSpecialty * quantitySpecialty;
                            Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                            return totalAmountSpecialty;
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
                                    double jumboPizzaSpecialty = 12;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays jumbo pizza segment subtotal 
                                    totalAmountSpecialty = jumboPizzaSpecialty * quantitySpecialty;
                                    Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                                    return totalAmountSpecialty;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }
                        break;

                    //Vegan Pizza Specialty
                    case 2:

                    try
                    {
                        double veganPizzaSpecialty = 8;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays jumbo pizza segment subtotal 
                        totalAmountSpecialty = veganPizzaSpecialty * quantitySpecialty;
                        Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                        return totalAmountSpecialty;

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
                            double veganPizzaSpecialty = 8;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays jumbo pizza segment subtotal 
                            totalAmountSpecialty = veganPizzaSpecialty * quantitySpecialty;
                            Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                            return totalAmountSpecialty;
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
                                    double veganPizzaSpecialty = 8;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays jumbo pizza segment subtotal 
                                    totalAmountSpecialty = veganPizzaSpecialty * quantitySpecialty;
                                    Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                                    return totalAmountSpecialty;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }

                    break;

                    //Spicy Pizza Specialty
                    case 3:

                    try
                    {
                        double spicyPizzaSpecialty = 8;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays jumbo pizza segment subtotal 
                        totalAmountSpecialty = spicyPizzaSpecialty * quantitySpecialty;
                        Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                        return totalAmountSpecialty;

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
                            double spicyPizzaSpecialty = 8;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays jumbo pizza segment subtotal 
                            totalAmountSpecialty = spicyPizzaSpecialty * quantitySpecialty;
                            Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                            return totalAmountSpecialty;
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
                                    double spicyPizzaSpecialty = 8;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantitySpecialty = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays jumbo pizza segment subtotal 
                                    totalAmountSpecialty = spicyPizzaSpecialty * quantitySpecialty;
                                    Console.WriteLine("Total amount for Jumbo Pizza(s) is " + "{0:C2}", +totalAmountSpecialty + ".\n");

                                    return totalAmountSpecialty;
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
                        totalAmountSpecialty = 0;
                        Console.WriteLine("\nProcess cancelled. Returning to Main Menu.");
                        return totalAmountSpecialty;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                }

            return totalAmountSpecialty;
        } // end of AddSpecialty()        
    } // end of SpecialtyMenu class
}
