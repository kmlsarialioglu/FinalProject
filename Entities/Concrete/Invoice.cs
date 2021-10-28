using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Invoice:IEntity
    {
        public long InvoiceId { get; set; }
        public long CompanyId { get; set; }
        public long AddressId { get; set; }
        public int InvoiceStatusId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool Status { get; set; }
    }
}
