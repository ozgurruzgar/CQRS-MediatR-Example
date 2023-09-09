using MediatR;
using System;

namespace MediatrExample.Med.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
