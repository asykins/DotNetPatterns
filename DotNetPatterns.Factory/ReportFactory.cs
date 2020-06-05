using DotNetPatterns.Factory.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory
{
    public class ReportFactory : AbstractFactory<ReportType, IReport>, IReportFactory
    {
        public ReportFactory() : base() { }
    }
}
