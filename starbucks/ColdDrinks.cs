internal class ColdDrinks : IFactory
{
    public itemDescription GetFactory(string ch)    //factory method of hot beverage factory
    {
        if (ch.ToLower().Equals("icedtea"))
        {
            return new IcedTea();        //returning a PineapplePassionfruit
        }
        else if (ch.ToLower().Equals("icedcoffee"))
        {
            return new IcedCoffee();          //returning a IcedAmericano
        }
        else
        {
            return new ColdBrew();          // returning a NitroColdBrews
        }
    }
}