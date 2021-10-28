using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserDetail : IEntity
    {
        public long UserDetailId { get; set; }
        public long UserId { get; set; }
        public long AddressId { get; set; }
        public long PhoneId { get; set; }
        public string NationalIdentity { get; set; }
        public bool Status { get; set; }
    }
}
