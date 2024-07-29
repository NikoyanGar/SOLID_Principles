namespace _001_Interface_Segregation_Solution
{
    public class InStoreOrder : IOrder, IOrderProcessing, ILabelPrinter
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

        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public void PrintLabel()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder()
        {
            throw new NotImplementedException();
        }
    }
}
