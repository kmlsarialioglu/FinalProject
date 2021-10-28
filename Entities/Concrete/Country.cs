using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Country:IEntity
    {
        public int CountryId { get; set; }
        public string NName { get; set; }
        public string TrName { get; set; }
        public string PhoneCode { get; set; }
        public bool Status { get; set; }
    }
}
