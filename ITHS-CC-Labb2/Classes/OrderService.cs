using System;
using ITHS_CC_Labb2.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService
    {
        // Dependency Injection
        private readonly IMessageTool _messageTool;

        public OrderService(IMessageTool messageTool)
        {
            _messageTool = messageTool;
        }
        public void ProcessOrder(IOrderModel order)
        {
            bool s = false;

            _messageTool.LogMessage("Attempting to process order with ID " + order.ID);
            if (order.Priority == OrderStatus.Normal)
            {
                s = _messageTool.MessageNormalSuccess(order);
            }
            else if (order.Priority == OrderStatus.Quick)
            {
                s = _messageTool.MessageQuickSuccess(order);
            }
            else if (order.Priority == OrderStatus.LightningSpeed)
            {
                s = _messageTool.MessageLightningSuccess(order);
            }
            else
            {
                s = false;
            }

            if (!s)
            {
                _messageTool.LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
        }

    }
}
