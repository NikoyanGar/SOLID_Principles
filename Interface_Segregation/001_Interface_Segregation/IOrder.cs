namespace _001_Interface_Segregation
{
    public interface IOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
        void CalculateTotal();
        void GenerateInvoice();
        void SendConfirmationEmail();
        void PrintLabel();
    }
}
