using System.Collections;
internal class Menu
{
    public Menu()
    {
        
    }
}


internal class Decaf : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public Decaf()
    {
        name = "Decaf";
        size = "Grande";
        price = 4.20;
    }

    
    public string ItemName()
    {
        return name;
    }

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

internal class Americano: itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public Americano()
    {
        name = "Americano";
        size = "Tall";
        price = 2.90;
    }
    public string ItemName()
    {
        return name;
    }

   

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

internal class Mocha : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public Mocha()
    {
        name = "Mocha";
        size = "Venti";
        price = 5.30;
    }

    public string ItemName()
    {
        return name;
    }

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

internal class IcedTea : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public IcedTea()
    {
        name = "Iced Tea";
        size = "Trenta";
        price = 7.30;
    }

    public string ItemName()
    {
        return name;
    }

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

internal class IcedCoffee : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public IcedCoffee()
    {
        name = "Iced Coffee";
        size = "Venti";
        price = 4.49;
    }

    public string ItemName()
    {
        return name;
    }

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

internal class ColdBrew : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public ColdBrew()
    {
        name = "Cold Brew";
        size = "Venti";
        price = 5.30;
    }

    public string ItemName()
    {
        return name;
    }

    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }
}

// Sandwich from Breakfast
internal class breakfastSandwich : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public breakfastSandwich()
    {
        name = "Breakfast Sandwich";
        size = "Large";
        price = 10.65;
    }

    public string ItemName()
    {
        return name;
    }
    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }

}

// Wrap from Breakfast
internal class breakfastWrap : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public breakfastWrap()
    {
        name = "Wrap";
        size = "Small";
        price = 4.99;
    }

    public string ItemName()
    {
        return name;
    }
    public string ItemSize()
    {
        return size;
    }
    public double ItemPrice()
    {
        return price;
    }
}

// Sandwich from lunch
internal class lunchSandwich : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public lunchSandwich()
    {
        name = "Lunch Sandwich";
        size = "FootLong";
        price = 15.65;
    }

    public string ItemName()
    {
        return name;
    }
    public string ItemSize()
    {
        return size;
    }

    public double ItemPrice()
    {
        return price;
    }

}

// Wrap from lunch
internal class lunchWrap : itemDescription
{
    private Menu menu = new Menu();
    private string name;
    private string size;
    private double price;

    public lunchWrap()
    {
        name = "Wrap";
        size = "Large";
        price = 8.99;
    }

    public string ItemName()
    {
        return name;
    }
    public string ItemSize()
    {
        return size;
    }
    public double ItemPrice()
    {
        return price;
    }
}



