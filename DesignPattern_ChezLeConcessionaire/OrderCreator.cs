using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_ChezLeConcessionaire
{
    class OrderCreator
    {
        enum PaymentType { Spot, Forward };
        private PaymentType paymentType;
        public void CreateNewOrder()
        {
            IOrder order = CreateOrder();
            if (order.IsValid())
            {
                order.Pay();
            }
        }
        private IOrder CreateOrder()
        {
            if (paymentType == PaymentType.Spot)
            {
                return new SpotOrder();
            }
            else
            {
                return new ForwardOrder();
            }
        }
    }
}
