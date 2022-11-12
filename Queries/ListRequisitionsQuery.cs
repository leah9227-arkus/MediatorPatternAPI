using MediatorPatternAPI.Models;
using MediatR;
using System.Collections.Generic;

namespace MediatorPatternAPI.Queries
{
    public class ListRequisitionsQuery : IRequest<ICollection<Requisition>>
    {
    }
}
