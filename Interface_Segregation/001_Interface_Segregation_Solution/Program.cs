namespace _001_Interface_Segregation_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new OnlineOrder();
            order.PlaceOrder();
            //order.SendConfirmationEmail();
            //order.SendConfirmationEmail();
            //order.GenerateInvoice();
            // order.PrintLabel();
        }
    }
    //Solution
    //By segregating the interfaces, we now have smaller, more focused interfaces that clients can choose to implement
    //based on their specific needs.This approach eliminates unnecessary dependencies and allows for better extensibility
    //and maintainability.Clients can implement only the interfaces they require, resulting in cleaner code that
    //is easier to understand, test, and modify.

    //Benefits
    //Using the ISP in C# enables us to create interfaces tailored to specific client requirements.
    //By avoiding the violation of ISP, we can build more flexible, modular, and maintainable code.
    //Breaking down large interfaces into smaller, cohesive ones reduces coupling and improves code organization.
}
