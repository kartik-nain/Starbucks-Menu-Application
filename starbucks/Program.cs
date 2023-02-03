Console.WriteLine("********************************************************************");
Console.WriteLine("             Welcome to Starbucks             ");
Console.WriteLine("             Address: 15 St.Martin Road             ");
Console.WriteLine("             Contact Number: +1 476-974-980             ");
Console.WriteLine("             Store Number: 3980             ");
Console.WriteLine("********************************************************************");

//Console.WriteLine("**** ****  **** **** **** ****");
//Console.WriteLine("*    *  *  **** **** **** ****");
//Console.WriteLine("*    *  *  *    *    **** ****");
//Console.WriteLine("**** ****  *    *    **** ****");

// calling facade method to simplify UI/UX, order is a facade class
Order.GetOrder();

Console.WriteLine("\nThanks for ordering with Starbucks, please visit again!");