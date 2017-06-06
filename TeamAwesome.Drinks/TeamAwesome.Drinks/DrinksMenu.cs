using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.Drinks
{
    public class DrinksMenu
    {

        public int ListOfDrinks()
        {
            //declare a variable
            int myDrinkSelection = 0;

            try
            {
                //display list of Drinks
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select food specialty from the following:");
                Console.WriteLine("[1] Water                   $0.00");
                Console.WriteLine("[2] Fountain (Small)        $1.00");
                Console.WriteLine("[3] Fountain (Large)        $1.50");
                Console.WriteLine("[4] Lemonade                $1.50");
                Console.WriteLine("[5] Back to Main Menu\n");

                //promts user to enter the selection
                Console.Write("Enter selection: ");
                myDrinkSelection = Convert.ToInt32(Console.ReadLine());
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
                    AddDrink();
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

                            AddDrink();
                        }

                        else if (userDecision2 == 'N')
                        {
                            Environment.Exit(0);
                        }
                    } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                }

            } //end of first catch    

            return myDrinkSelection;
        } //end of ListOfDrinks property


        public double AddDrink()
        {

            //declare variables
            int customerSelection = 0, quantity;
            double totalDrink = 0;

            customerSelection = ListOfDrinks();

            //begin process using a switch-case method inside a do-while loop
            switch (customerSelection)
            {
                //water
                case 1:
                    try
                    {
                        double waterPrice = 0;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays water segment subtotal 
                        totalDrink = waterPrice * quantity;
                        Console.WriteLine("Total amount for Water(s) is " + "{0:C2}", +totalDrink + ".\n");

                        return totalDrink;

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
                            double Water = 12;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays water segment subtotal 
                            totalDrink = Water * quantity;
                            Console.WriteLine("Total amount for Water(s) is " + "{0:C2}", +totalDrink + ".\n");

                            return totalDrink;
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
                                    double waterPrice = 0;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantity = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays water segment subtotal 
                                    totalDrink = waterPrice * quantity;
                                    Console.WriteLine("Total amount for Water(s) is " + "{0:C2}", totalDrink + ".\n");

                                    return totalDrink;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }
                    break;

                //Cola Small
                case 2:

                    try
                    {
                        double colaSmall = 1;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays small cola segment subtotal 
                        totalDrink = colaSmall * quantity;
                        Console.WriteLine("Total amount for Small Cola(s) is " + "{0:C2}", totalDrink + ".\n");

                        return totalDrink;

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
                            double colaSmall = 1;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays small cola subtotal 
                            totalDrink = colaSmall * quantity;
                            Console.WriteLine("Total amount for Small Cola(s) is " + "{0:C2}", totalDrink + ".\n");

                            return totalDrink;
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
                                    double colaSmall = 1;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantity = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays small cola segment subtotal 
                                    totalDrink = colaSmall * quantity;
                                    Console.WriteLine("Total amount for Small Cola(s) is " + "{0:C2}", totalDrink + ".\n");

                                    return totalDrink;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }

                    break;

                //Large Cola
                case 3:

                    try
                    {
                        double largeCola = 1.5;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays large colasegment subtotal 
                        totalDrink = largeCola * quantity;
                        Console.WriteLine("Total amount for Large Cola(s) is {0:C2}\n", totalDrink);

                        return totalDrink;

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
                            double largeCola = 1.5;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays large cola segment subtotal 
                            totalDrink = largeCola * quantity;
                            Console.WriteLine("Total amount for Large Cola(s) is {0:C2}\n", totalDrink);

                            return totalDrink;
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
                                    double largeCola = 1.5;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantity = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays large cola segment subtotal 
                                    totalDrink = largeCola * quantity;
                                    Console.WriteLine("Total amount for Large Cola(s) is {0:C2}\n", totalDrink);

                                    return totalDrink;
                                }

                                else if (userDecision2 == 'N')
                                {
                                    Environment.Exit(0);
                                }
                            } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop

                        }
                    }

                    break;

                //Lemonade
                case 4:

                    try
                    {
                        double lemonade = 1.5;

                        //promts user to enter quantity
                        Console.Write("Enter quantity: ");
                        quantity = Convert.ToInt32(Console.ReadLine());

                        //calculate and displays lemonade segment subtotal 
                        totalDrink = lemonade * quantity;
                        Console.WriteLine("Total amount for Lemonade(s) is {0:C2}\n", totalDrink);

                        return totalDrink;

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
                            double lemonade = 1.5;

                            //promts user to enter quantity
                            Console.Write("\nEnter quantity: ");
                            quantity = Convert.ToInt32(Console.ReadLine());

                            //calculate and displays lemonade segment subtotal 
                            totalDrink = lemonade * quantity;
                            Console.WriteLine("Total amount for Lemonade(s) is {0:C2}\n", totalDrink);

                            return totalDrink;
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
                                    double largeCola = 1.5;

                                    //promts user to enter quantity
                                    Console.Write("\nEnter quantity: ");
                                    quantity = Convert.ToInt32(Console.ReadLine());

                                    //calculate and displays lemonade segment subtotal 
                                    totalDrink = largeCola * quantity;
                                    Console.WriteLine("Total amount for Lemonade(s) is {0:C2}\n", totalDrink);

                                    return totalDrink;
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
                case 5:
                    try
                    {
                        totalDrink = 0;
                        Console.WriteLine("\nProcess cancelled. Returning to Main Menu.");
                        return totalDrink;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }

            return totalDrink;
        }
    } // end of Drink class
}

