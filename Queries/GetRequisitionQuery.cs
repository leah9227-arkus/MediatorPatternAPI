using MediatorPatternAPI.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorPatternAPI.Queries
{
    public class GetRequisitionQuery : IRequest<Requisition>
    {
        public int Id { get; }

        public GetRequisitionQuery(int id)
        {
            Id = id;
        }
    }
}
