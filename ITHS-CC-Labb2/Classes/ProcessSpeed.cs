using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2.Classes
{
    public class ProcessSpeed : IProcessSpeed
    {
        public bool ProcessOrderNormally(IOrderModel order)
        {
            // Some logic we don't care about,
            Console.WriteLine("This order is being processed at NORMAL SPEED!");
            return true;
            
        }

        public bool ProcessOrderQuickly(IOrderModel order)
        {
            // Some logic we don't care about,
            Console.WriteLine("This order is being processed QUICKLY!");
            return true;
            
        }

        public bool ProcessOrderLightningSpeed(IOrderModel order)
        {
            // Some logic we don't care about,
            Console.WriteLine("This order is being processed at LIGHTNING SPEED!");
            return true;
            
        }
    }
}
