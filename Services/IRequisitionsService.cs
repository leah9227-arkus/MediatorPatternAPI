using MediatorPatternAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Services
{
    public interface IRequisitionsService
    {
        public Task<ICollection<Requisition>> ListRequisitions();
        public Task<Requisition> GetRequisitionById(int id);
        public Task<Requisition> CreateRequisition(Requisition requisition);
    }
}
