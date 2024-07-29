namespace _001_Interface_Segregation_Solution
{
    // Implement only the necessary interfaces in client classes.
    public class OnlineOrder : IOrder, IOrderProcessing, IInvoiceGenerator, IEmailSender
    {
        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

        // Implementation of required methods.
        public void CancelOrder()
        {
            throw new NotImplementedException();
        }

        public void GenerateInvoice()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void SendConfirmationEmail()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
