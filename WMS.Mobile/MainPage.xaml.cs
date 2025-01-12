// MainPage.xaml.cs
using Microsoft.Maui.Controls;

namespace WMS.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Event handler for the "Go to Inventory" button
        private async void OnGoToInventoryClicked(object sender, System.EventArgs e)
        {
            // Navigate to the InventoryPage
            await Navigation.PushAsync(new Views.InventoryPage());
        }
    }
}