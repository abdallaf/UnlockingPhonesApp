using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnlockPhones
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page6 : ContentPage
	{
		public Page6 ()
		{
			InitializeComponent ();
		}
        private async void CheckUserInput(object sender, EventArgs e)
        {
            bool isImeiEmpty = string.IsNullOrEmpty(EnteryIMEI.Text);
            bool isEmailEmpty = string.IsNullOrEmpty(EnteryEmail.Text);

            if (isImeiEmpty || isEmailEmpty)
            {
                await DisplayAlert("Failed", "Please fill all requirements and try again", "Retry");

            }
            else if (PickModel.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please select your phone model", "OK");
                return;
            }
            else if (PickNetwork.SelectedIndex == -1)
            {
                await DisplayAlert("Error", "Please select your Network provider", "OK");
                return;
            }
            else
            {
                continueBtn.IsEnabled = true;
                await DisplayAlert("Successful", "Please tap Continue", "OK");
            }

        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page8());
        }
    }
}