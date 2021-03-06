using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderModel : IOrderModel
    {
        public Guid ID { get; set; }
        public int TotalPrce { get; set; }
        public OrderStatus Priority { get; set; }
        public string Email { get; set; }
    }

    public enum OrderStatus
    {
        Normal,
        Quick,
        LightningSpeed
    }
}
