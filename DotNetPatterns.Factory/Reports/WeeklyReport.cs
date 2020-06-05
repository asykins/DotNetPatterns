using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory.Reports
{
    public class WeeklyReport : Report
    {
        public WeeklyReport(DateTime startDate)
            :base(startDate, startDate.AddDays(7)) { }

        public override ReportType Type => ReportType.Weekly;
    }
}
