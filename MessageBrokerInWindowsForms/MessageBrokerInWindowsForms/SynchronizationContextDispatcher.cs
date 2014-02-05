using System;
using System.Threading;
using Topics.Radical.ComponentModel;

namespace MessageBrokerInWindowsForms
{
    public sealed class SynchronizationContextDispatcher : IDispatcher
    {
        private readonly SynchronizationContext _synchronizationContext;

        public SynchronizationContextDispatcher(SynchronizationContext synchronizationContext)
        {
            if (synchronizationContext == null) throw new ArgumentNullException("synchronizationContext");
            _synchronizationContext = synchronizationContext;
        }

        public void Invoke(Delegate d, params object[] args)
        {
            _synchronizationContext.Send(state =>
            {
                d.DynamicInvoke(args);
            }, null);
        }

        public void Dispatch(Action action)
        {
            _synchronizationContext.Send(state =>
            {
                action();
            }, null);
        }

        public void Dispatch<T>(T arg, Action<T> action)
        {
            _synchronizationContext.Send(state =>
            {
                action(arg);
            }, null);
        }

        public void Dispatch<T1, T2>(T1 arg1, T2 arg2, Action<T1, T2> action)
        {
            _synchronizationContext.Send(state =>
            {
                action(arg1, arg2);
            }, null);
        }

        public TResult Dispatch<TResult>(Func<TResult> func)
        {
            TResult result = default(TResult);
            _synchronizationContext.Send(state =>
            {
                result = func();
            }, null);
            return result;
        }

        public bool IsSafe
        {
            get { return false; }
        }
    }
}