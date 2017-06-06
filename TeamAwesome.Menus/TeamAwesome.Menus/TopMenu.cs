using System;
using TeamAwesome.SubMainMenu;

namespace TeamAwesome.Menus
{
    public class TopMenu
    {
        public int MainMenu()
        {
            //declare variable(s)
            int mySelection = 0;
            SubMain mySubMain = new SubMain();

            try
            {
                Console.WriteLine("=======================================================================================================================");
                Console.WriteLine("Select order item from the following:");
                Console.WriteLine("[1] Appetizer");
                Console.WriteLine("[2] Combo");
                Console.WriteLine("[3] Drinks");
                Console.WriteLine("[4] Desserts");
                Console.WriteLine("[5] Specialty");
                Console.WriteLine("[6] Checkout");
                Console.WriteLine("[7] To exit the application\n");

                //promts user to enter selection
                Console.Write("Enter selection: ");
                return mySelection = Convert.ToInt32(Console.ReadLine());
            } //end of first try

            catch (Exception myError)
            {
                Console.WriteLine(myError.Message + "\n");
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    Console.Clear();
                    mySubMain.SubMainMenu();
                }

                else if (userDecision == 'N')
                {
                    Environment.Exit(0);
                }

                else  if (userDecision != 'Y' || userDecision != 'N')
                {                   
                    Console.WriteLine(myError.Message + "\n");

                    do
                    {
                        Console.Write("\nDo you want to continue? \n[Y]es or [N]o: ");
                        char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());

                        if (userDecision2 == 'Y')
                        {
                            Console.Clear();
                            mySubMain.SubMainMenu();
                        }

                        else if (userDecision2 == 'N')
                        {
                            Environment.Exit(0);
                        }
                    } while (userDecision != 'Y' || userDecision != 'N'); //end of do-while loop
                                         
                }                                                                                                    
            } // end of second catch

            return mySelection;
        } //end of Main Menu property

    }
}
