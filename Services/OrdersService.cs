using MediatorPatternAPI.Commands;
using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public class OrdersService : IOrdersService
    {
        public async Task<Order> CreateOrder(CreateOrderCommand order)
        {
            var response = new Order()
            {
                Id = 123,
                CreationDate = DateTime.Now,
                Name = order.Name,
                Quantity = order.Quantity
            };

            return response;
        }

        public async Task<Order> GetOrder(int orderId)
        {
            var response = new Order()
            {
                Id = orderId,
                Name = "Es la orden que pediste we",
                Quantity = 999999,
                CreationDate = DateTime.Now,
            };

            return response;
        }

        public async Task<ICollection<Order>> ListOrders()
        {
            var response = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    CreationDate = DateTime.Now,
                    Name = "First one",
                    Quantity = 1
                },
                new Order()
                {
                    Id = 2,
                    CreationDate = DateTime.Now,
                    Name = "Second one",
                    Quantity = 2
                },
                new Order()
                {
                    Id = 3,
                    CreationDate = DateTime.Now,
                    Name = "Third one",
                    Quantity = 3
                }
            };

            return response;
        }
    }
}
