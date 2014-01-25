using System.Diagnostics;
using System.Threading;
using log4net;

namespace LoggingInterceptor.Step1.ConsoleApp
{
    public class TheIncredibleJob
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TheIncredibleJob));

        public void DoTheJob()
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

        private object KnowYourEnemies()
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

        private void FightThemAll(object enemies)
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