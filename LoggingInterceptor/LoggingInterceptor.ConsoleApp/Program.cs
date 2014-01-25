using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace LoggingInterceptor.ConsoleApp
{
    // basic app with all the methods in the same class

    internal class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        private static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            log.Info("Application started");
            DoTheJob();
            log.Info("Application end");
        }

        private static void DoTheJob()
        {
            Stopwatch sw = null;
            if (log.IsDebugEnabled)
            {
                sw = Stopwatch.StartNew();
                log.Debug("Enter DoTheJob()");
            }

            try
            {
                var enemies = KnowYourEnemies();

                FightThemAll(enemies);

                // .....
                Thread.Sleep(200);
            }
            finally
            {
                if (log.IsDebugEnabled)
                {
                    log.DebugFormat("[{0} ms] Exit DoTheJob()", sw != null ? sw.ElapsedMilliseconds.ToString() : "N/A");
                }
            }
        }

        private static object KnowYourEnemies()
        {
            Stopwatch sw = null;
            if (log.IsDebugEnabled)
            {
                sw = Stopwatch.StartNew();
                log.Debug("Enter KnowYourEnemies()");
            }

            try
            {
                log.Debug("Returning the enemies...");
                Thread.Sleep(200);
                return "all around you!";
            }
            finally
            {
                if (log.IsDebugEnabled)
                {
                    log.DebugFormat("[{0} ms] Exit KnowYourEnemies()", sw != null ? sw.ElapsedMilliseconds.ToString() : "N/A");
                }
            }
        }

        private static void FightThemAll(object enemies)
        {
            Stopwatch sw = null;
            if (log.IsDebugEnabled)
            {
                sw = Stopwatch.StartNew();
                log.Debug("Enter FightThemAll()");
            }

            try
            {
                // a lot of incredible code!!
                Thread.Sleep(600);
                log.DebugFormat("Your enemies are {0}", enemies);
            }
            finally
            {
                if (log.IsDebugEnabled)
                {
                    log.DebugFormat("[{0} ms] Exit FightThemAll()", sw != null ? sw.ElapsedMilliseconds.ToString() : "N/A");
                }
            }
        }
    }
}