using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubSubSubSubCategory : IEntity
    {
        public int SubSubSubSubCategoryId { get; set; }
        public int SubSubSubCategoryId { get; set; }
        public string SubSubSubSubCategoryName { get; set; }
        public bool Status { get; set; }
    }
}
