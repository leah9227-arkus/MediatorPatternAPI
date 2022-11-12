using MediatorPatternAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Commands
{
    public class CreateRequisitionCommand : IRequest<Requisition>
    {
        public string Name { get; set; }
        public int RequestedBy { get; set; }
        public DateTime RequestedTime { get; set; }
        public bool IsActive { get; set; }
    }
}
