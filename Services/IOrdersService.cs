using MediatorPatternAPI.Commands;
using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public interface IOrdersService
    {
        public Task<ICollection<Order>> ListOrders();
        public Task<Order> GetOrder(int orderId);
        public Task<Order> CreateOrder(CreateOrderCommand order);
    }
}
