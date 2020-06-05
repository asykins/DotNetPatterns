using DotNetPatterns.Factory.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Factory
{
    public interface IReportFactory : IAbstractFactory<ReportType, IReport>
    {
        
    }
}
