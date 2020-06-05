using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory.Reports
{
    public class MonthlyReport : Report
    {
        public MonthlyReport(DateTime startDate) 
            : base(startDate, startDate.AddMonths(1)) { }
        public override ReportType Type => ReportType.Monthly;
    }
}
