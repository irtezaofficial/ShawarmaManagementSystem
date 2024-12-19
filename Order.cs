﻿namespace ShawarmaManagementSystem
{
    internal class Order
    {
        private IOrderState _orderState;
        public Order()
        {
            _orderState = new IdleState();
        }

        public void SetOrderState(IOrderState newState)
        {
            _orderState = newState;
        }

        public string GetOrderState()
        {
            return _orderState.GetOrderState();
        }

        public void ProcessOrder()
        {
            _orderState.ProcessOrder(this);
        }

        public void DeliverOrder()
        {
            _orderState.DeliverOrder(this);
        }

        public void CancelOrder()
        {
            _orderState.CancelOrder(this);
        }

        public void CompleteOrder()
        {
            _orderState.CompleteOrder(this);
        }
    }
}
