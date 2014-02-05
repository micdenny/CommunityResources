using System;
using System.Windows.Forms;
using Topics.Radical.ComponentModel.Messaging;

namespace MessageBrokerInWindowsForms
{
    public partial class Form1 : Form
    {
        private readonly IMessageBroker _broker;
        private OpenForm2MessageHandler _openForm2MessageHandler;

        public Form1()
        {
            InitializeComponent();

            _broker = ServiceLocator.MessageBroker;

            _broker.Subscribe<SomethingDifferentMessage>(this, InvocationModel.Safe, (o, message) =>
            {
                this.textBox1.Text = message.Message;
            });

            // handle global messages (the code to manage global messages could go in a separated class, 
            // radical does this in a completly decoupled way, using a bootstrapper with an IoC container (castle)
            // and a lot of conventions that help you avoiding writing repeated code, you endup just writing the class to handle the message
            _openForm2MessageHandler = new OpenForm2MessageHandler(_broker);
        }
        
        private void openForm2Button_Click(object sender, System.EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();

            // you should also open windows using messaging, to be completly decoupled from form2
            // this kind of messages are often globally managed by classes that are instanciated at application startup
            // and that subscribe to some specific global message type like OpenWindow, CloseApplication, SaveCurrentContext, ...
            //_broker.Dispatch(this, new OpenForm2Message());
        }

        private void sendSomethingButton_Click(object sender, System.EventArgs e)
        {
            _broker.Dispatch(this, new SomethingMessage
            {
                Message = "I got something to say"
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_openForm2MessageHandler != null)
                _openForm2MessageHandler.Dispose();
            if (_broker != null)
            {
                _broker.Unsubscribe<SomethingDifferentMessage>(this);
            }
            base.OnClosed(e);
        }
    }
}
