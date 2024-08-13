using Itemizer.Domain.Common;
using Itemizer.Domain.DTOs;

namespace Itemizer.Domain.Services
{
    public interface IItemService
    {
        Task<ItemDTO> GetItem(int inventoryId);
        Task<IEnumerable<ItemDTO>> GetItems();
        Task<IEnumerable<ItemDTO>> GetItems(PaginationOptions options);
        Task AddItem(ItemDTO itemDTO);
        Task DeleteItem(int itemId);
        Task UpdateItem(ItemDTO itemDTO);
    }
}