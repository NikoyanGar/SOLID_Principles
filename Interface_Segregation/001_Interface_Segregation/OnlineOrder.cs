namespace _001_Interface_Segregation
{
    public class OnlineOrder : IOrder
    {
        // Implementation of all methods.
        public void CalculateTotal()
        {
            throw new NotImplementedException();
        }

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

        public void PrintLabel()
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
