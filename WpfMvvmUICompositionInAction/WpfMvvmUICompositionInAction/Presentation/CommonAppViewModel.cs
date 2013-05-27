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
    public class CommonAppViewModel : AbstractViewModel
    {
        readonly IMessageBroker messageBroker;

        public ICommand OpenStartScreen { get; private set; }

        public CommonAppViewModel(IMessageBroker messageBroker)
        {
            Debug.WriteLine("CommonAppViewModel()");

            this.messageBroker = messageBroker;

            this.OpenStartScreen = DelegateCommand.Create()
                .OnExecute(p => OpenStartScreenHandler());
        }

        public void OpenStartScreenHandler()
        {
            Debug.WriteLine("OpenStartScreenHandler()");
            this.messageBroker.Broadcast(this, new OpenStartScreenMessage());
        }
    }
}
