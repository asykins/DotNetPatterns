using System;

namespace DotNetPatterns.Factory.Reports
{
    public abstract class Report : IReport
    {
        public Report(DateTime startDate, DateTime endDate) =>
            (StartDate, EndDate) = (startDate, endDate);

        public abstract ReportType Type { get; }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }

        public override string ToString() 
            => $"Report of type {Type} has started at {StartDate} and ended at {EndDate}";
    }
}
