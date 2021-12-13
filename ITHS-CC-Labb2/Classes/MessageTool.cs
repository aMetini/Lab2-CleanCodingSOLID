using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Classes
{
    public class MessageTool : IMessageTool
    {
        private readonly IProcessSpeed _processSpeed;

        public MessageTool(IProcessSpeed processSpeed)
        {
            _processSpeed = processSpeed;
        }

        public void SendNotifictionEmail(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            LogMessage($"Notification sent to email {email} for order {ID}");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }

        public bool MessageNormalSuccess(IOrderModel order)
        {
            _processSpeed.ProcessOrderNormally(order);
            LogMessage($"Succesfully processed order with ID {order.ID} at NORMAL SPEED!");
            SendNotifictionEmail(order.Email, order.ID);
            return true;
        }

        public bool MessageQuickSuccess(IOrderModel order)
        {
            _processSpeed.ProcessOrderQuickly(order);
            LogMessage($"Succesfully processed order with ID {order.ID} at QUICK SPEED!");
            SendNotifictionEmail(order.Email, order.ID);
            return true;
        }

        public bool MessageLightningSuccess(IOrderModel order)
        {
            _processSpeed.ProcessOrderLightningSpeed(order);
            LogMessage($"Succesfully processed order with ID {order.ID} at LIGHTNING SPEED!");
            SendNotifictionEmail(order.Email, order.ID);
            return true;
        }
    }
}
