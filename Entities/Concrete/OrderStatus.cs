using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class OrderStatus:IEntity
    {
        public int OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public bool Status { get; set; }
    }
}
