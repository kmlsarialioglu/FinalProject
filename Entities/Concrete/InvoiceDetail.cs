using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class InvoiceDetail:IEntity
    {
        public long InvoiceDetailId { get; set; }
        public long InvoiceId { get; set; }
        public long ProductId { get; set; }
        public int Count { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
    }
}
