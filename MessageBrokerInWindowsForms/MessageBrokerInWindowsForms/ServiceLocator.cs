using System;
using System.Threading;
using Topics.Radical.ComponentModel.Messaging;
using Topics.Radical.Messaging;

namespace MessageBrokerInWindowsForms
{
    public sealed class ServiceLocator
    {
        private static IMessageBroker _messageBroker;
        private static Lazy<IMessageBroker> _lazyMessageBroker = new Lazy<IMessageBroker>(() =>
        {
            return new MessageBroker(new SynchronizationContextDispatcher(SynchronizationContext.Current));
        });

        public static IMessageBroker MessageBroker
        {
            get
            {
                if (_messageBroker == null)
                    return _lazyMessageBroker.Value;
                return _messageBroker;
            }
        }

        public static void Register(IMessageBroker messageBroker)
        {
            _messageBroker = messageBroker;
        }
    }
}
