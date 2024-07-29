namespace _001_Interface_Segregation_Solution
{
    public interface IOrder
    {
        void PlaceOrder();
        void CancelOrder();
        void UpdateOrder();
    }
}
