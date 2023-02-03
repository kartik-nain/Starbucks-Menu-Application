internal class Order //facade class
{
    internal static void GetOrder() //facade method
    {
        Bag bag = Bag.getBag();         // singleton cart //to store drinks
        Console.WriteLine("\n~~~~HERE IS THE STARBUCKS MENU~~~~~");
        
        while (true)
        {
            string ch;
            string customerChoice;
            // displaying choices for user
            Console.WriteLine("\nPress 1 for Hot Drinks Menu");
            Console.WriteLine("Press 2 for Cold Drinks Menu");
            Console.WriteLine("Press 3 for Hot Breakfast Menu");
            Console.WriteLine("Press 4 for Lunch Menu");
            Console.WriteLine("\nWhat would you like to have");

           ch = Console.ReadLine();

            // getting an instance of factory from abstract factory
            IFactory item = Contain.GetFactory(ch);
            
            if (ch.Equals("1"))
            {
                Console.WriteLine("\nWhat would you like to have in Hot Drinks..? \nDecaf \nAmericano \nMocha\n");
                customerChoice = Console.ReadLine();
                itemDescription id = item.GetFactory(customerChoice);   // creating menu item from factory
                bag.addHotDrinksToBag(id);     // adding to hot beverage
                bag.addToBag(id);                        // adding to bill amount
                Console.WriteLine("\nItem-" +customerChoice + " is added in your cart");
            }
            if (ch.Equals("2"))
            {
                Console.WriteLine("\nWhat would you like to have in Cold Drinks..? \nIcedTea \nIcedCoffee \nColdBrew\n");
                customerChoice = Console.ReadLine();
                itemDescription id = item.GetFactory(customerChoice);   // creating menu item from factory
                // adding to cold beverage
                bag.addToBag(id);         // adding to bill amount           
                bag.addColdDrinksToBag(id);
                Console.WriteLine("\nItem-"+customerChoice + " is added in your cart");

            }
            if (ch.Equals("3"))
            {
                Console.WriteLine("\nWhat would you like to have in Hot Breakfast..? \nBreakfast Sandwiches \nBreakfast Wraps\n");
                customerChoice = Console.ReadLine();
                itemDescription id = item.GetFactory(customerChoice);   // creating menu item from factory
                bag.addHotBreakfastToBag(id);            // adding to breakfast
                bag.addToBag(id);                        // adding to bill amount
                Console.WriteLine("\nItem-" + customerChoice + " is added in your cart");
            }
            if (ch.Equals("4"))
            {
                Console.WriteLine("\nWhat would you like to have in Lunch..? \nLunch Sandwiches \nLunch Wraps\n");
                customerChoice = Console.ReadLine();
                itemDescription id = item.GetFactory(customerChoice);   // creating menu item from factory
                bag.addLunchToBag(id);                 // adding to lunch
                bag.addToBag(id);                       // adding to bill amount
                Console.WriteLine("\nItem-" + customerChoice + " is added in your cart");
            }
            Console.WriteLine("\n----Would you like to have something else?---\n If yes, Press Enter, ortherwise please press 'q' to exit");
            string ch1 = Console.ReadLine();
            if (ch1.ToLower().Equals("q"))
            {
                break;
            }

        }

        Console.WriteLine("\n----Please choose your Payment Method----\nCASH \nCARD");
        string ch2 = Console.ReadLine();

        // fetching the payment method object from factory
        IPaymentMethod pm = PaymentMethodFactory.paymentMethodFactory(ch2);
        pm.addAmount(bag.calculateTotal());       // adding payment to display in bill
        bag.displayTotalAmount();                         // displaying the bill item
        string type = pm.GetType().ToString(); // display the payment method type

        Console.WriteLine("\nPayment Method : " + type.Substring(type.Length - 4));
        // displaying the total amount
        Console.WriteLine("Total Bill : " + String.Format("{0:0.00}", pm.getAmount()));
    }
}
