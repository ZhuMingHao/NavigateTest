using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigateTest
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page5 : ContentPage
	{
		public Page5 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.RemovePage( Navigation.NavigationStack.Where(a=> a is Page4).FirstOrDefault());
        }

        private void PushClick(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
            foreach (var item in Navigation.NavigationStack)
            {
                System.Diagnostics.Debug.WriteLine(item.GetType().Name);
            }
        }
    }
}