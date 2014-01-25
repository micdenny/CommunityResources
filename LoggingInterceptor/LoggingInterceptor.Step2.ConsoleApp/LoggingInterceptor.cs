using System.Diagnostics;
using Castle.DynamicProxy;
using log4net;

namespace LoggingInterceptor.Step2.ConsoleApp
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var log = LogManager.GetLogger(invocation.TargetType);
            
            Stopwatch sw = null;
            if (log.IsDebugEnabled)
            {
                sw = Stopwatch.StartNew();
                log.DebugFormat("Enter {0}()", invocation.Method.Name);
            }

            try
            {
                invocation.Proceed();
            }
            finally
            {
                if (log.IsDebugEnabled)
                {
                    log.DebugFormat("[{0} ms] Exit {1}()", sw != null ? sw.ElapsedMilliseconds.ToString() : "N/A", invocation.Method.Name);
                }
            }
        }
    }
}