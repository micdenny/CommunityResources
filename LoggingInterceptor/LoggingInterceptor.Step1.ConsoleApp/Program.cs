using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LoggingInterceptor.Step1.ConsoleApp
{
    // refactored app with a separated class

    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            log.Info("Application started");
            var theIncredibleJob = new TheIncredibleJob();
            theIncredibleJob.DoTheJob();
            log.Info("Application end");
        }
    }
}