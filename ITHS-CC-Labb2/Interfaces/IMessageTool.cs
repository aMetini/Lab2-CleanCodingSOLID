using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public interface IMessageTool
    {
        void SendNotifictionEmail(string email, Guid ID);
        void LogMessage(string message);
        bool MessageNormalSuccess(IOrderModel order);
        bool MessageQuickSuccess(IOrderModel order);
        bool MessageLightningSuccess(IOrderModel order);
    }
}
