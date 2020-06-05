using DotNetPatterns.Factory.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DotNetPatterns.Factory
{
    public class UnityConfig
    {
        private static UnityConfig _instance;

        private IUnityContainer _unityContainer;

        public static IUnityContainer Container
        {
            get
            {
                if (_instance == null)
                    _instance = new UnityConfig();
                return _instance._unityContainer;
            }
        }

        private UnityConfig() 
        {
            _unityContainer = new UnityContainer();
            RegisterTypes();
        }

        private void RegisterTypes()
        {
            _unityContainer.RegisterFactory<IReportFactory>((unityContainer, type, name) => {
                var factory = new ReportFactory();
                factory.container.Add(ReportType.Weekly, typeof(WeeklyReport));
                factory.container.Add(ReportType.Monthly, typeof(MonthlyReport));
                return factory;
            });
        }
    }
}
