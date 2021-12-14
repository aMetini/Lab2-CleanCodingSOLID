using System;
using ITHS_CC_Labb2.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public abstract class OrderService
    {
        //// Dependency Injection
        protected readonly IMessageTool _messageTool;
        
        protected OrderService orderService;

        public abstract void ProcessOrder(IOrderModel order);

        public OrderService(IMessageTool messageTool)
        {
            _messageTool = messageTool;
        }

    }
}
