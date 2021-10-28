using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public long ProductId { get; set; }
        public int CategoryId { get; set; }
        public long SuplierId  { get; set; }
        public long BrandId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public decimal UnitPrice { get; set; }
        public int InStock { get; set; }
        public bool Status { get; set; }
    }
}
