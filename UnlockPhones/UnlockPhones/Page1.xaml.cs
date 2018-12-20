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
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
            //Local images to be used in different platforms
            var image = new Image { Source = "unlock.jpg" };
            InitializeComponent ();
            image.Source = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("unlock.jpg") : ImageSource.FromFile("Images/unlock.jpg");

        }
        //navigation page when button isclicked
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}