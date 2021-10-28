using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public long ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageFile{ get; set; }
        public bool Status { get; set; }
    }
}
