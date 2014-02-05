using System;
using Topics.Radical.ComponentModel.Messaging;

namespace MessageBrokerInWindowsForms
{
    public class OpenForm2MessageHandler : IDisposable
    {
        private readonly IMessageBroker _broker;

        public OpenForm2MessageHandler(IMessageBroker broker)
        {
            if (broker == null) throw new ArgumentNullException("broker");
            _broker = broker;
            _broker.Subscribe<OpenForm2Message>(this, InvocationModel.Safe, HandleMessage);
        }

        private void HandleMessage(object o, OpenForm2Message openForm2Message)
        {
            var form2 = new Form2();
            form2.Show();
        }

        public void Dispose()
        {
            if (_broker != null) _broker.Unsubscribe<OpenForm2Message>(this);
        }
    }
}
