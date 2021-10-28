using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ReportNames : IEntity
    {
        public int ReportNamesId { get; set; }
        public string ReportName { get; set; }
        public bool Status { get; set; }
    }
}
