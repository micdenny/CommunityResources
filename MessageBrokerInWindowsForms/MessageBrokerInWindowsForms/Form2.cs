using System;
using System.Windows.Forms;
using Topics.Radical.ComponentModel.Messaging;

namespace MessageBrokerInWindowsForms
{
    public partial class Form2 : Form
    {
        private readonly IMessageBroker _broker;

        public Form2()
        {
            InitializeComponent();

            _broker = ServiceLocator.MessageBroker;
            _broker.Subscribe<SomethingMessage>(this, InvocationModel.Safe, (o, message) =>
            {
                this.textBox1.Text = message.Message;
            });
        }
        
        private void sendSomethingDifferentButton_Click(object sender, EventArgs e)
        {
            _broker.Dispatch(this, new SomethingDifferentMessage
            {
                Message = "I killed your baby today"
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_broker != null)
            {
                _broker.Unsubscribe<SomethingMessage>(this);
            }
            base.OnClosed(e);
        }
    }
}
