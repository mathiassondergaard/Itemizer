using Itemizer.Domain.DTOs;
using Itemizer.Domain.Common;

namespace Itemizer.Domain.Services;

public interface IInventoryService
{
    Task<InventoryDTO> GetInventory(int inventoryId);
    Task<IEnumerable<InventoryDTO>> GetInventories();
    Task<IEnumerable<InventoryDTO>> GetInventories(PaginationOptions options);
    Task AddInventory(InventoryDTO inventoryDTO);
    Task DeleteInventory(int inventoryId);
    Task UpdateInventory(InventoryDTO inventoryDTO);
}