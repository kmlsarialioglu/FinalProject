using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Phone : IEntity
    {
        public long PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
