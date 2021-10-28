using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fax : IEntity
    {
        public long FaxId { get; set; }
        public string FaxNumber { get; set; }
        public bool Status { get; set; }
    }
}
