﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Classes
{
    public class OrderServiceQuick : OrderService
    {
        public OrderServiceQuick(IMessageTool messageTool) : base(messageTool)
        {

        }

        public override void ProcessOrder(IOrderModel order)
        {
            bool s = _messageTool.MessageQuickSuccess(order);

            if (!s)
            {
                _messageTool.LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
        }
    }
}
