using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Topics.Radical.ComponentModel.Messaging;
using Topics.Radical.Windows.Input;
using Topics.Radical.Windows.Presentation;
using WpfMvvmUICompositionInAction.Messaging;

namespace WpfMvvmUICompositionInAction.Presentation
{
    public class ShellStartScreenViewModel : AbstractViewModel
    {
        readonly IMessageBroker messageBroker;

        public ICommand OpenView { get; private set; }

        public ShellStartScreenViewModel(IMessageBroker messageBroker)
        {
            Debug.WriteLine("ShellStartScreenViewModel()");

            this.messageBroker = messageBroker;

            this.OpenView = DelegateCommand.Create()
                .OnExecute(OpenViewHandler);
        }

        public void OpenViewHandler(object parameter)
        {
            Debug.WriteLine("OpenViewHandler({0})", parameter);

            if (parameter == null) return;

            var app = (KnownApps)parameter;
            switch (app)
            {
                case KnownApps.CompositeApp:
                    this.messageBroker.Broadcast(this, new OpenCompositeAppMessage());
                    break;
                case KnownApps.CommonApp:
                    this.messageBroker.Broadcast(this, new OpenCommonAppMessage());
                    break;
            }
        }
    }
}
