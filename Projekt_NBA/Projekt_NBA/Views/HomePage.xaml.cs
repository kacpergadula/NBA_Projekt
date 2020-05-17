using Projekt_NBA.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projekt_NBA.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomeViewModel(Navigation);
        }
    }
}