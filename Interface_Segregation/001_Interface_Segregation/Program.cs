namespace _001_Interface_Segregation
{
    //The Interface Segregation Principle (ISP) says to create smaller,
    //specialized interfaces that cater to clients’ specific needs.
    //It discourages large interfaces that include unnecessary methods,
    //so that clients are not burdened with functionality they don’t require.
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new OnlineOrder();
            order.CalculateTotal();
            order.PlaceOrder();
            order.GenerateInvoice();
            order.SendConfirmationEmail();
            // order.PrintLabel();
        }
    }
    //In the previous example, we have an IOrder interface that contains methods for placing an order,
    //canceling an order, updating an order, calculating the total, generating an invoice,
    //sending a confirmation email, and printing a label.

    //However, not all client classes implementing this interface require or use all these methods.
    //This violates ISP, since clients are forced to depend on methods they don’t need.
}
