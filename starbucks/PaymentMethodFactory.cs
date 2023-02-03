internal class PaymentMethodFactory
{
    public static IPaymentMethod paymentMethodFactory(string ch2)
    {
        if(ch2.ToLower().Equals("card"))
        {
            return new paidByCard();
        }
        else
        {
            return new paidByCash();
        }
    }
}