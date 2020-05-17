using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt_NBA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage ()
		{
			InitializeComponent ();
		}

        private void Help_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Api użyte z: ", "https://www.balldontlie.io", "Zamknij");
        }
    }
}