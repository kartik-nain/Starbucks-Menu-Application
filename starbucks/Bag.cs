using System.Collections;

internal class Bag
{
    //using different data structures
    private List<double> total = new List<double>();
    private LinkedList<itemDescription> hotDrinks = new LinkedList<itemDescription>();
    private ArrayList colddrinks = new ArrayList();
    private Stack<itemDescription> hotBreakfast = new Stack<itemDescription>();
    private Queue<itemDescription> lunch = new Queue<itemDescription>();
    private static Bag bag;
    public static Bag getBag() //singleton
    {
        if (bag == null)
        {
            return bag = new Bag();
        }
        return bag;
    }

    //using data structure for all the methods in te application

    public void addHotDrinksToBag(itemDescription id)
    {
        hotDrinks.AddLast(id);
    }

   
    public void addColdDrinksToBag(itemDescription id)
    {
       colddrinks.Add(id);
    }
    public void addHotBreakfastToBag(itemDescription id)
    {
        hotBreakfast.Push(id);
    }
    public void addLunchToBag(itemDescription id)
    {
        lunch.Enqueue(id);
    }

    // methods to display details from item description in data structures
    public void purchasedHotDrinks()
    {
        foreach (itemDescription id in hotDrinks)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,10}  {2,10}", id.ItemName(), id.ItemSize(), id.ItemPrice()));
        }
    }
    public void purchasedColdDrinks()
    {
        foreach (itemDescription id in colddrinks)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,10}  {2,10}", id.ItemName(), id.ItemSize(), id.ItemPrice()));
        }
    }
    
    public void purchasedHotBreakfast()
    {
        foreach (itemDescription id in hotBreakfast)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,10}  {2,10}", id.ItemName(), id.ItemSize(), id.ItemPrice()));
        }
    }
    public void purchasedLunch()
    {
        foreach (itemDescription id in lunch)
        {
            Console.WriteLine(String.Format("{0,-10}  {1,10}  {2,10}", id.ItemName(), id.ItemSize(), id.ItemPrice()));
        }
    }

    // method to add prices to the bill list
    public void addToBag(itemDescription id)
    {
        total.Add(id.ItemPrice());
    }

    // calculating total of prices in bill
    public double calculateTotal()
    {
        double amount = 0;
        foreach (var item in total)
        {
            amount += item;
        }
        return amount;
    }

    // for displaying bill
    public void displayTotalAmount()
    {
        Console.WriteLine("-----PURCHASED ITEM DETAILS-----");
        Console.WriteLine(String.Format("\n{0,-10}  {1,10}  {2,10}", "ITEMS", "SIZE", "PRICES"));
        purchasedHotDrinks();
        purchasedColdDrinks();
        purchasedHotBreakfast();
        purchasedLunch();
    }

}