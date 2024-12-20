namespace ShawarmaManagementSystem
{
    internal interface IOrderState
    {
        string GetOrderState();
        void ProcessOrder(OrderContext order);
        void DeliverOrder(OrderContext order);
        void CancelOrder(OrderContext order);
        void CompleteOrder(OrderContext order);
    }
}
