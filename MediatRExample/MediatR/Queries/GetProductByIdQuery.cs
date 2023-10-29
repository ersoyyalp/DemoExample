using MediatR;

namespace MediatRExample.MediatR.Queries
{
    public class GetProductByIdQuery: IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
