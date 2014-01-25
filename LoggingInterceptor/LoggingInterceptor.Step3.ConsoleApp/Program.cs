using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using log4net;

namespace LoggingInterceptor.Step3.ConsoleApp
{
    // refactoring step2 to create a better decoupled application, 
    // having different concerns in separated classes

    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            log.Info("Application started");

            // the registration part could be put in an installer class, see http://docs.castleproject.org/Windsor.Installers.ashx
            var container = new WindsorContainer().Register
                (
                    Component.For<LoggingInterceptor>().LifestyleTransient(),
                    Component.For<IEnemiesFinder>().ImplementedBy<EnemiesFinder>()
                             .Interceptors<LoggingInterceptor>(),
                    Component.For<IEnemiesFighter>().ImplementedBy<EnemiesFighter>()
                             .Interceptors<LoggingInterceptor>(),
                    Component.For<TheIncredibleJob>()
                             .Interceptors<LoggingInterceptor>()
                );

            var theIncredibleJob = container.Resolve<TheIncredibleJob>();
            theIncredibleJob.DoTheJob();

            container.Release(theIncredibleJob);

            log.Info("Application end");
        }
    }
}