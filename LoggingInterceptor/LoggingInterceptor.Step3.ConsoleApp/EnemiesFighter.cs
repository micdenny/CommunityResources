using System.Threading;
using log4net;

namespace LoggingInterceptor.Step3.ConsoleApp
{
    public class EnemiesFighter : IEnemiesFighter
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EnemiesFighter));

        public void FightThemAll(object enemies)
        {
            // a lot of incredible code!!
            Thread.Sleep(600);
            log.DebugFormat("Your enemies are {0}", enemies);
        }
    }
}