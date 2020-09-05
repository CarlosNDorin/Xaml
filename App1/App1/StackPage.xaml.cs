using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StackPage : ContentPage
	{
		public StackPage ()
		{
			InitializeComponent ();
		}
        private void Button_Clicked_Login(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Clickeaste en login", "bye");
        }
        private void Button_Clicked_Register(object sender, EventArgs e)
        {

        }
    }
}