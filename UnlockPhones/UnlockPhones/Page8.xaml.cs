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
	public partial class Page8 : ContentPage
	{
		public Page8 ()
		{
			InitializeComponent ();
		}
        //method to verify user has filled all entries required
        private async void CheckUserInput(object sender, EventArgs e)
        {
            bool isInputEmpty = string.IsNullOrEmpty(EntryCreditCard.Text);
            bool isInputEmpty1 = string.IsNullOrEmpty(EntryName.Text);
            bool isInputEmpty2 = string.IsNullOrEmpty(EnteryDate.Text);
            bool isInputEmpty3 = string.IsNullOrEmpty(EnteryCVV.Text);

            if (isInputEmpty || isInputEmpty1 || isInputEmpty2 || isInputEmpty3)
            {
                await DisplayAlert("Failed", "Please fill all requirements and try again", "Retry");

            }
         
            else
            {
                confirmBtn.IsEnabled = true;
                await DisplayAlert("Successful", "Please tap confirm", "OK");
            }

        }
        //method to verify and checkout
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page9());
        }
    }
}