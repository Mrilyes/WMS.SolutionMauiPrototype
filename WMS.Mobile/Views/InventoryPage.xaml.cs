// WMS.Mobile/Views/InventoryPage.xaml.cs
using System.Collections.ObjectModel;
using WMS.Core.Models;
using WMS.Mobile.Services;

namespace WMS.Mobile.Views // Ensure this matches the x:Class in XAML
{
    public partial class InventoryPage : ContentPage
    {
        private readonly InventoryService _inventoryService = new();

        public ObservableCollection<InventoryItem> InventoryItems { get; set; } = new();

        public InventoryPage()
        {
            InitializeComponent();
            BindingContext = this;
            LoadInventory();
        }

        private async void LoadInventory()
        {
            var items = await _inventoryService.GetInventoryAsync();
            InventoryItems.Clear();
            foreach (var item in items)
            {
                InventoryItems.Add(item);
            }
        }

        private async void OnAddItemClicked(object sender, EventArgs e)
        {
            var newItem = new InventoryItem { Name = "New Item", Quantity = 1 };
            await _inventoryService.AddInventoryItemAsync(newItem);
            LoadInventory();
        }
    }
}