// WMS.Mobile/Services/InventoryService.cs
using System.Net.Http.Json;
using WMS.Core.Models;

public class InventoryService
{
    private readonly HttpClient _httpClient;

    public InventoryService()
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7202/api/") // Update with your API URL
        };
    }

    public async Task<List<InventoryItem>> GetInventoryAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<InventoryItem>>("inventory");
    }

    public async Task AddInventoryItemAsync(InventoryItem item)
    {
        await _httpClient.PostAsJsonAsync("inventory", item);
    }
}