using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topics.Radical.Windows.Presentation;

namespace WpfMvvmUICompositionInAction.Presentation
{
    public class CommonViewModel : AbstractViewModel
    {
        public int RandomNumber
        {
            get
            {
                return this.GetPropertyValue(() => this.RandomNumber);
            }
            set
            {
                this.SetPropertyValue(() => this.RandomNumber, value);
            }
        }

        public CommonViewModel()
        {
            Debug.WriteLine("CommonViewModel()");

            var rnd = new Random();

            this.GetPropertyMetadata(() => this.RandomNumber)
                .WithDefaultValue(rnd.Next());
        }
    }
}
