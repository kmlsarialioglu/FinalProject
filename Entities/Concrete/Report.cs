using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Report:IEntity
    {
        public long ReportId { get; set; }
        public long UserId { get; set; }
        public long CompanyId { get; set; }
        public int ReportNameId { get; set; }
        public string ReportNumber { get; set; }
        public string ReportDetail { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime ReportDateEnd { get; set; }
        public bool Status { get; set; }

    }
}
