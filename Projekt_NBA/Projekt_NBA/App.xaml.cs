using Projekt_NBA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Projekt_NBA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new RootTabbedPage();
        }
    }
}
