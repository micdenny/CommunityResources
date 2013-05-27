using System.Windows.Controls;
using Topics.Radical.Windows.Presentation.ComponentModel.Regions;

namespace WpfMvvmUICompositionInAction.Presentation
{
    /// <summary>
    /// Interaction logic for CommonView.xaml
    /// </summary>
    [InjectViewInRegion(Named = "CommonContentRegion")]
    public partial class CommonView : UserControl
    {
        public CommonView()
        {
            InitializeComponent();
        }
    }
}
