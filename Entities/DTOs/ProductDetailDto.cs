using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto

    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public string SuplierName { get; set; }
        public string ProductDetail { get; set; }
        public int InStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
