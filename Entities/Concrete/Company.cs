using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public long CompanyId { get; set; }
        public long UserId { get; set; }
        public long AddressId { get; set; }
        public long PhoneId { get; set; }
        public long FaxId { get; set; }
        public string CompanyName { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string WebSite { get; set; }
        public bool Status { get; set; }

    }
}
