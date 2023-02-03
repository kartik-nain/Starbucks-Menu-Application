internal class Lunch : IFactory
{
    public itemDescription GetFactory(string ch)    //factory method of breakfast factory
    {
        if (ch.ToLower().Equals("lunch sandwich"))
        {
            return new lunchSandwich();        //returning a sandwich
        }
        else
        {
            return new breakfastWrap();            // returning a wrap
        }
    }
}