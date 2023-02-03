internal class HotBreakfast : IFactory
{
    public itemDescription GetFactory(string ch)    //factory method of breakfast factory
    {
        if (ch.ToLower().Equals("breakfast sandwich"))
        {
            return new breakfastSandwich();        //returning a sandwich
        }
        else
        {
            return new breakfastWrap();            // returning a wrap
        }
    }

    
}