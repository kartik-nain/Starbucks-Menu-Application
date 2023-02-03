internal abstract class Contain
{
    public static string Name;
    internal static IFactory GetFactory(string choice)
    {
        Name = choice;
        if (Name.Equals("1"))
        {
            return new HotDrinks();        //returning Hot Drinks
        }
        if (Name.Equals("2"))
        {
            return new ColdDrinks();       //returning Cold Drinks
        }
        if (Name.Equals("3"))
        {
            return new HotBreakfast();          //returning Hot Breakfast
        }
        if (Name.Equals("4"))
        {
            return new Lunch();              //returning Lunch
        }
        else
        {
            return null;
        }
    }
}