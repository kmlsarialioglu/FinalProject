using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubSubCategory : IEntity
    {
        public int SubSubCategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string SubSubCategoryName { get; set; }
        public bool Status { get; set; }
    }
}
