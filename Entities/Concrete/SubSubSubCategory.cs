using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubSubSubCategory : IEntity
    {
        public int SubSubSubCategoryId { get; set; }
        public int SubSubCategoryId { get; set; }
        public string SubSubSubCategoryName { get; set; }
        public bool Status { get; set; }
    }
}
