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
    public class GetRequisitionQueryHandler : IRequestHandler<GetRequisitionQuery, Requisition>
    {
        private readonly IRequisitionsService _requisitionService;

        public GetRequisitionQueryHandler(IRequisitionsService requisitionService)
        {
            _requisitionService = requisitionService;
        }

        public async Task<Requisition> Handle(GetRequisitionQuery request, CancellationToken cancellationToken)
        {
            var response = await _requisitionService.GetRequisitionById(request.Id);
            return response;
        }
    }
}
