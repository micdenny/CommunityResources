using System.Diagnostics;
using System.Threading;
using log4net;

namespace LoggingInterceptor.Step3.ConsoleApp
{
    public class TheIncredibleJob
    {
        //private static readonly ILog log = LogManager.GetLogger(typeof(TheIncredibleJob));

        private readonly IEnemiesFinder _enemiesFinder;
        private readonly IEnemiesFighter _enemiesFighter;

        // this is a tipical dependency injection pattern (DI)
        public TheIncredibleJob(IEnemiesFinder enemiesFinder, IEnemiesFighter enemiesFighter)
        {
            _enemiesFinder = enemiesFinder;
            _enemiesFighter = enemiesFighter;
        }

        // should add the virtual keyword to let the castle dynamic proxy
        // extend the behavior of the method. See the next step to understand
        // how to avoid changing the signature of the method using interfaces instead
        public virtual void DoTheJob()
        {
            var enemies = _enemiesFinder.KnowYourEnemies();

            _enemiesFighter.FightThemAll(enemies);

            // .....
            Thread.Sleep(200);
        }

        // you can't intercept methods that are not exposed!!
        // these methods are going to be not testable (are private methods), 
        // it is better to create a component for each, that exposes public methods 
        // that can be easily tested and also easily replaced with a different
        // implementation if in the future is needed it

        //private object KnowYourEnemies()
        //{
        //    log.Debug("Returning the enemies...");
        //    Thread.Sleep(200);
        //    return "all around you!";
        //}

        //private void FightThemAll(object enemies)
        //{
        //    // a lot of incredible code!!
        //    Thread.Sleep(600);
        //    log.DebugFormat("Your enemies are {0}", enemies);
        //}
    }
}