using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public class RequisitionsService : IRequisitionsService
    {
        public async Task<ICollection<Requisition>> ListRequisitions()
        {
            var response = new List<Requisition>()
            {
                new Requisition()
                {
                    Id = 1,
                    IsActive = true,
                    Name = "Harcoded from micro service xd",
                    RequestedBy = 0,
                    RequestedTime = DateTime.Now
                }
            };

            return response;
        }

        public async Task<Requisition> GetRequisitionById(int id)
        {
            var response = new Requisition()
            {
                Id = id,
                IsActive = true,
                Name = "Requested requisition",
                RequestedBy = -1,
                RequestedTime = DateTime.Now.AddDays(-2)
            };

            return response;        
        }

        public async Task<Requisition> CreateRequisition(Requisition requisition)
        {
            var response = requisition;
            response.Name = $"from service and xd: {response.Name}";
            response.Id = DateTime.Now.Millisecond;

            return response;
        }
    }
}
