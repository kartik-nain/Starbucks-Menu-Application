internal class paidByCard : IPaymentMethod
{
    private double amount;

    // for adding the total amount paid by card
    public void addAmount(double a)
    {
        amount = a;
    }

    // for getting the amount paid by cash
    public double getAmount()
    {
        return amount;
    }
}