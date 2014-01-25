using System.Diagnostics;
using System.Threading;
using log4net;

namespace LoggingInterceptor.Step2.ConsoleApp
{
    public class TheIncredibleJob
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TheIncredibleJob));

        // should add the virtual keyword to let the castle dynamic proxy
        // extend the behavior of the method. See the next step to understand
        // how to avoid changing the signature of the method using interfaces instead
        public virtual void DoTheJob()
        {
            var enemies = KnowYourEnemies();

            FightThemAll(enemies);

            // .....
            Thread.Sleep(200);
        }

        // you can't intercept methods that are not exposed
        // see the next step to enable interception also for these

        private object KnowYourEnemies()
        {
            log.Debug("Returning the enemies...");
            Thread.Sleep(200);
            return "all around you!";
        }

        private void FightThemAll(object enemies)
        {
            // a lot of incredible code!!
            Thread.Sleep(600);
            log.DebugFormat("Your enemies are {0}", enemies);
        }
    }
}