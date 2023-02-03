internal class paidByCash : IPaymentMethod
{
    private double amount;

    // for adding the total amount paid by cash
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