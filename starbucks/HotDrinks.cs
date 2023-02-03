internal class HotDrinks : IFactory
{
    public itemDescription GetFactory(string ch)    //factory method of hot beverage factory
    {
        if (ch.ToLower().Equals("decaf"))
        {
            return new Decaf();        //returning a hazelnut
        }
        else if (ch.ToLower().Equals("americano"))
        {
            return new Americano();          //returning a americano
        }
        else
        {
            return new Mocha();          // returning a mocha
        }
    }
}