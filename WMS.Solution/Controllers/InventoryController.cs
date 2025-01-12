// WMS.API/Controllers/InventoryController.cs
using Microsoft.AspNetCore.Mvc;
using WMS.Core.Models; // Use the shared model

[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    private static List<InventoryItem> _inventory = new();

    [HttpGet]
    public ActionResult<List<InventoryItem>> GetInventory()
    {
        return Ok(_inventory);
    }

    [HttpPost]
    public ActionResult AddInventoryItem([FromBody] InventoryItem item)
    {
        _inventory.Add(item);
        return Ok();
    }
}