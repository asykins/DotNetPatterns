using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory.Reports
{
    public interface IReport
    {
        ReportType Type { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
