using System.Threading;
using log4net;

namespace LoggingInterceptor.Step3.ConsoleApp
{
    public class EnemiesFinder : IEnemiesFinder
    {
        // you can also avoid this coupling, letting the castle windsor injecting for you
        // see the logging facility http://docs.castleproject.org/Windsor.Logging-Facility.ashx
        private static readonly ILog log = LogManager.GetLogger(typeof(EnemiesFinder));

        public object KnowYourEnemies()
        {
            log.Debug("Returning the enemies...");
            Thread.Sleep(200);
            return "all around you!";
        }
    }
}