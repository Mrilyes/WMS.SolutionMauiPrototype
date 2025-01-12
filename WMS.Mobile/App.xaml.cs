// App.xaml.cs
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace WMS.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set MainPage as the root page
            MainPage = new NavigationPage(new MainPage());
        }
    }
}