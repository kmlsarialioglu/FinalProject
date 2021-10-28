using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class AddressNames : IEntity
    {
        public int AddressNamesId { get; set; }
        public string AddressName { get; set; }
        public bool Status { get; set; }

    }
}
