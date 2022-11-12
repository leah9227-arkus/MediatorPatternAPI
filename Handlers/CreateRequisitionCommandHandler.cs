using MediatorPatternAPI.Commands;
using MediatorPatternAPI.Models;
using MediatorPatternAPI.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Handlers
{
    public class CreateRequisitionCommandHandler : IRequestHandler<CreateRequisitionCommand, Requisition>
    {
        private readonly IRequisitionsService _requisitionsService;

        public CreateRequisitionCommandHandler(IRequisitionsService requisitionsService)
        {
            _requisitionsService = requisitionsService;
        }

        public async Task<Requisition> Handle(CreateRequisitionCommand request, CancellationToken cancellationToken)
        {
            var requisition = new Requisition()
            {
                IsActive = request.IsActive,
                Name = request.Name,
                RequestedBy = request.RequestedBy,
                RequestedTime = request.RequestedTime
            };

            var response = await _requisitionsService.CreateRequisition(requisition);

            return response;
        }
    }
}
