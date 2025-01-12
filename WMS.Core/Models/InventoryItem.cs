// WMS.Core/Models/InventoryItem.cs
namespace WMS.Core.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }
    }
}