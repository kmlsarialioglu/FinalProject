using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public long AddressId { get; set; }
        public int AddressNamesId { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string AddressDetail { get; set; }
        public string PostalCode { get; set; }
        public bool Status { get; set; }

    }
}
