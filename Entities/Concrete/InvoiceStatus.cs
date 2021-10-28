using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InvoiceStatus:IEntity
    {
        public int InvoiceStatusId { get; set; }
        public string InvoiceStatusName { get; set; }
        public bool Status { get; set; }
    }
}
