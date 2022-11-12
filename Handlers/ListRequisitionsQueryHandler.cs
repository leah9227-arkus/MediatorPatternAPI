using MediatorPatternAPI.Models;
using MediatorPatternAPI.Queries;
using MediatorPatternAPI.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Handlers
{
    public class ListRequisitionsQueryHandler : IRequestHandler<ListRequisitionsQuery, ICollection<Requisition>>
    {
        private readonly IRequisitionsService _requisitionService;

        public ListRequisitionsQueryHandler(IRequisitionsService requisitionService)
        {
            _requisitionService = requisitionService;
        }

        public async Task<ICollection<Requisition>> Handle(ListRequisitionsQuery request, CancellationToken cancellationToken)
        {
            var response = await _requisitionService.ListRequisitions();
            return response;
        }
    }
}
