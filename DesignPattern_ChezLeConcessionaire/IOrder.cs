using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern_ChezLeConcessionaire
{
    interface IOrder
    {
        double Pay();
        bool IsValid();
    }
}
