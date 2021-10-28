using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDto:IDto
    {
        public string Name { get; set; }
        public string PCName{ get; set; }
        public string PSC1Name { get; set; }
        public string PSC2Name { get; set; }
        public string PSC3Name { get; set; }
        public string PSC4Name { get; set; }
    }
}
