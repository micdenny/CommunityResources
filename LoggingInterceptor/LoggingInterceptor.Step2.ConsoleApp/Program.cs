using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using log4net;

namespace LoggingInterceptor.Step2.ConsoleApp
{
    // application bootstrapped from a windsor container to allow logging interceptor on the job class

    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            log.Info("Application started");

            var container = new WindsorContainer().Register
                (
                    Component.For<LoggingInterceptor>().LifestyleTransient(),
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