using BookShoppingCartMvcUI.Models;

namespace BookShoppingCartMvcUI.Repository
{
    public interface IUserOrderRepository
    {
        Task<IEnumerable<Order>> UserOrders();
    }
}