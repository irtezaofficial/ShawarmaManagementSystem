﻿namespace ShawarmaManagementSystem
{
    internal interface IOrderState
    {
        void ProcessOrder(Order order);
        void DeliverOrder(Order order);
        void CancelOrder(Order order);
        void CompleteOrder(Order order);
    }
}