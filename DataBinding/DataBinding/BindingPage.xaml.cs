using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BindingPage : ContentPage
	{
        // instantiate a myAdder object from the class
        myAdder calc = new myAdder();

		public BindingPage ()
		{
			InitializeComponent ();
            mySlider.Value = 100;   // set starting value
            this.BindingContext = calc;
		}

        private void changeValuesBtn_Clicked(object sender, EventArgs e)
        {
            calc.Arg1 = 100;
            calc.Arg2 = 23;
        }
    }
}