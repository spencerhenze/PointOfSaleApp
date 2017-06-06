using System;
using TeamAwesome.Slogan;
using TeamAwesome.Menus;
using TeamAwesome.FoodSpecialty;
using TeamAwesome.Calculations;
using TeamAwesome.CashPayment;
using TeamAwesome.CreditPayment;
using TeamAwesome.DebitPayment;
using TeamAwesome.Appetizers;
using TeamAwesome.Combos;
using TeamAwesome.Dessert;
using TeamAwesome.Drinks;
using TeamAwesome.CalcCoupon;

namespace TeamAwesome.SubMainMenu
{
    public class SubMain
    {

        public void SubMainMenu()
        {
            CalcSubtotal orderSubtotal = new CalcSubtotal();
            CalculateTax orderTax = new CalculateTax();
            double qualifiedDiscountAmount;
            double couponDiscountAmount;
            double totalDiscount;
            

            try
            {
                DisplaySlogan myDisplaySlogan = new DisplaySlogan();
                myDisplaySlogan.GreetingSlogan();

                int userInput = 0;               

                //Instantiate new object from TopMenu class
                TopMenu myTopMenu = new TopMenu();

                do
                {

                    userInput = myTopMenu.MainMenu();
                    if (userInput == 1 || userInput == 2 || userInput == 3 || userInput == 4 || userInput == 5 || userInput == 6 || userInput == 7)
                    {



                        switch (userInput)
                        {
                            case 1:
                                AppetizerMenu myAppetizer = new AppetizerMenu();
                                double appetizerItemTotal = myAppetizer.AddAppetizer();
                                orderSubtotal.AddCost(appetizerItemTotal);
                                Console.WriteLine("The order subtotal has been updated to: " + "{0:C2}", +orderSubtotal.runningSubtotal);
                                break;
                            case 2:
                                Console.WriteLine("Combo");
                                ComboMenu myCombo = new ComboMenu();
                                double comboItemTotal = myCombo.AddCombo();
                                orderSubtotal.AddCost(comboItemTotal);
                                Console.WriteLine("The order subtotal has been updated to: " + "{0:C2}", +orderSubtotal.runningSubtotal);

                                break;
                            case 3:
                                Console.WriteLine("Drinks");
                                DrinksMenu myDrink = new DrinksMenu();
                                double drinkItemTotal = myDrink.AddDrink();
                                orderSubtotal.AddCost(drinkItemTotal);
                                Console.WriteLine("The order subtotal has been updated to: " + "{0:C2}", +orderSubtotal.runningSubtotal);


                                break;
                            case 4:
                                Console.WriteLine("Desserts");
                                DessertMenu myDessert = new DessertMenu();
                                double dessertItemTotal = myDessert.AddDessert();
                                orderSubtotal.AddCost(dessertItemTotal);
                                Console.WriteLine("The order subtotal has been updated to: " + "{0:C2}", +orderSubtotal.runningSubtotal);

                                break;
                            case 5:
                                SpecialtyMenu mySpecialty = new SpecialtyMenu();
                                double specialtyItemTotal = mySpecialty.AddSpecialty();
                                orderSubtotal.AddCost(specialtyItemTotal);
                                Console.WriteLine("The order subtotal has been updated to: " + "{0:C2}", +orderSubtotal.runningSubtotal);
                                break;
                            case 6:
                                Console.WriteLine("\n=======Checkout=======");

                                //display the subtotal of the payment
                                Console.WriteLine("\nOrder Subtotal: {0:C}", orderSubtotal.runningSubtotal);
                                CalcDiscount orderDiscount = new CalcDiscount(orderSubtotal.runningSubtotal);
                                Coupon orderCoupon = new Coupon(orderSubtotal.runningSubtotal);



                                try
                                {
                                    //asks user if discounts are applicable
                                    Console.WriteLine("\nCheck for discounts? [Y] or [N]");
                                    string checkResponse = Console.ReadLine().ToUpper();

                                    if (checkResponse == "Y")
                                    {
                                        qualifiedDiscountAmount = orderDiscount.getDiscounts();
                                        couponDiscountAmount = orderCoupon.GetCoupon();
                                        totalDiscount = qualifiedDiscountAmount + couponDiscountAmount;
                                    }
                                    else
                                    {
                                        qualifiedDiscountAmount = 0;
                                        couponDiscountAmount = 0;
                                        totalDiscount = 0;
                                    }

                                    //calculate tax using subtotal with discount subtracted
                                    double taxDue = orderTax.CalcTax((orderSubtotal.runningSubtotal - totalDiscount)); // subtract discount from subtotal as it is passed in to calculate tax

                                    //calculate order grand total by adding the running subtotal to the result of the CalcTax(subtotal) method which value is contained in the taxDue variable.
                                    double grandTotal = (orderSubtotal.runningSubtotal - totalDiscount) + taxDue;

                                    // print out the info.
                                    Console.WriteLine("\nOrder Subtotal: {0:C2}", orderSubtotal.runningSubtotal);
                                    Console.WriteLine("Coupon savings = -{0:C}", couponDiscountAmount);
                                    Console.WriteLine("Other Discounts: -{0:C2}", qualifiedDiscountAmount);
                                    Console.WriteLine("Tax: {0:C2}", taxDue);
                                    Console.WriteLine("\nGrand Total: {0:C2}", grandTotal);

                                    //promts user to select payment method
                                    Console.WriteLine("\nPlease select payment method: [1] Cash, [2] Credit, [3] Debit");
                                    int payMethod = Convert.ToInt32(Console.ReadLine());

                                    switch (payMethod)
                                    {
                                        case 1:
                                            Cash myCash = new Cash(grandTotal);
                                            myCash.PayWithCash();
                                            break;

                                        case 2:
                                            Credit myCredit = new Credit(grandTotal);
                                            myCredit.PayWithCredit();
                                            break;

                                        case 3:
                                            Debit myDebit = new Debit(grandTotal);
                                            myDebit.PayWithDebit();
                                            break;

                                    } //end of switch

                                } //end of orignal checkout try

                                catch (Exception myError)
                                {
                                    Console.WriteLine(myError.Message + "\n");
                                    Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                                    char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                                    if (userDecision == 'Y')
                                    {
                                        //asks user if discounts are applicable
                                        Console.WriteLine("\nCheck for discounts? [Y] or [N]");
                                        string checkResponse = Console.ReadLine().ToUpper();

                                        if (checkResponse == "Y")
                                        {
                                            qualifiedDiscountAmount = orderDiscount.getDiscounts();
                                            couponDiscountAmount = orderCoupon.GetCoupon();
                                            totalDiscount = qualifiedDiscountAmount + couponDiscountAmount;
                                        }
                                        else
                                        {
                                            qualifiedDiscountAmount = 0;
                                            couponDiscountAmount = 0;
                                            totalDiscount = 0;
                                        }

                                        //calculate tax using subtotal with discount subtracted
                                        double taxDue = orderTax.CalcTax((orderSubtotal.runningSubtotal - totalDiscount));


                                        //calculate order grand total by adding the running subtotal to the result of the CalcTax(subtotal) method
                                        double grandTotal = (orderSubtotal.runningSubtotal - totalDiscount) + taxDue;

                                        // discount subtracted two lines above.
                                        Console.WriteLine("\nOrder Subtotal: {0:C2}", orderSubtotal.runningSubtotal);
                                        Console.WriteLine("Coupon savings = -{0:C}", couponDiscountAmount);
                                        Console.WriteLine("Other Discounts: -{0:C2}", qualifiedDiscountAmount);
                                        Console.WriteLine("Tax: {0:C2}", taxDue);
                                        Console.WriteLine("\nGrand Total: {0:C2}", grandTotal);

                                        //promts user to select payment method
                                        Console.WriteLine("\nPlease select payment method: [1] Cash, [2] Credit, [3] Debit");
                                        int payMethod = Convert.ToInt32(Console.ReadLine());

                                        switch (payMethod)
                                        {
                                            case 1:
                                                Cash myCash = new Cash(grandTotal);
                                                myCash.PayWithCash();
                                                break;

                                            case 2:
                                                Credit myCredit = new Credit(grandTotal);
                                                myCredit.PayWithCredit();
                                                break;

                                            case 3:
                                                Debit myDebit = new Debit(grandTotal);
                                                myDebit.PayWithDebit();
                                                break;
                                        }
                                    } // end user decision = Y



                                    else if (userDecision == 'N')
                                    {
                                        Environment.Exit(0);
                                    }

                                    else if (userDecision != 'Y' || userDecision != 'N')
                                    {
                                        Console.WriteLine(myError.Message + "\n");

                                        do
                                        {
                                            Console.Write("\nDo you want to continue? \n[Y]es or [N]o: ");
                                            char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());


                                            if (userDecision2 == 'Y')
                                            {
                                                //asks user if discounts are applicable
                                                Console.WriteLine("\nCheck for discounts? [Y] or [N]");
                                                string checkResponse = Console.ReadLine().ToUpper();

                                                if (checkResponse == "Y")
                                                {
                                                    qualifiedDiscountAmount = orderDiscount.getDiscounts();
                                                    couponDiscountAmount = orderCoupon.GetCoupon();
                                                    totalDiscount = qualifiedDiscountAmount + couponDiscountAmount;
                                                }
                                                else
                                                {
                                                    qualifiedDiscountAmount = 0;
                                                    couponDiscountAmount = 0;
                                                    totalDiscount = 0;
                                                }

                                                //calculate tax using subtotal with discount subtracted
                                                double taxDue = orderTax.CalcTax((orderSubtotal.runningSubtotal - totalDiscount));

                                                // subtract discount from subtotal as it is passed in to calculate tax

                                                //calculate order grand total by adding the running subtotal to the result of the CalcTax(subtotal) method
                                                double grandTotal = (orderSubtotal.runningSubtotal - totalDiscount) + taxDue;

                                                // discount subtracted two lines above.
                                                Console.WriteLine("\nOrder Subtotal: {0:C2}", orderSubtotal.runningSubtotal);
                                                Console.WriteLine("Coupon savings = -{0:C}", couponDiscountAmount);
                                                Console.WriteLine("Other Discounts: -{0:C2}", qualifiedDiscountAmount);
                                                Console.WriteLine("Tax: {0:C2}", taxDue);
                                                Console.WriteLine("\nGrand Total: {0:C2}", grandTotal);

                                                //promts user to select payment method
                                                Console.WriteLine("\nPlease select payment method: [1] Cash, [2] Credit, [3] Debit");
                                                int payMethod = Convert.ToInt32(Console.ReadLine());

                                                switch (payMethod)
                                                {
                                                    case 1:
                                                        Cash myCash = new Cash(grandTotal);
                                                        myCash.PayWithCash();
                                                        break;

                                                    case 2:
                                                        Credit myCredit = new Credit(grandTotal);
                                                        myCredit.PayWithCredit();
                                                        break;

                                                    case 3:
                                                        Debit myDebit = new Debit(grandTotal);
                                                        myDebit.PayWithDebit();
                                                        break;
                                                }
                                            }

                                            else if (userDecision2 == 'N')
                                            {
                                                Environment.Exit(0);
                                            }
                                        } while (userDecision != 'Y' || userDecision != 'N');

                                    }
                                }
                                break; // end of checkout block

                            case 7:
                                Environment.Exit(0);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please enter a valid selection (1-7).");
                    }


                } while (userInput != 10);
            } //end of first try

            catch (Exception myError)
            {
                Console.WriteLine(myError.Message + "\n");
                Console.Write("Do you want to continue? \n[Y]es or [N]o: ");
                char userDecision = Convert.ToChar(Console.ReadLine().ToUpper());

                if (userDecision == 'Y')
                {
                    Console.Clear();
                    SubMainMenu();
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
                        Console.Write("\nDo you want to continue? \n[Y]es or [N]o: ");
                        char userDecision2 = Convert.ToChar(Console.ReadLine().ToUpper());


                        if (userDecision2 == 'Y')
                        {
                            Console.Clear();
                            SubMainMenu();
                        }

                        else if (userDecision2 == 'N')
                        {
                            Environment.Exit(0);
                        }
                    } while (userDecision != 'Y' || userDecision != 'N');

                }               
            }
        } //end of first catch

    } // end of  SubMain class
}
    

