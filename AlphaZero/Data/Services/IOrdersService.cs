using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaZero.Models;

namespace AlphaZero.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
