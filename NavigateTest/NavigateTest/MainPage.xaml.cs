using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigateTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Navigation.ModalStack.Where(a => a is MainPage).FirstOrDefault() != null)
            {
                CloseBtn.IsVisible = true;
            }

        }
        private async void CloseClick(object sender, EventArgs e)
        {

            await Navigation.PopModalAsync();
        }
    }
}
