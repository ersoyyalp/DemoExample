using MediatR;

namespace MediatRExample.MediatR.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {

        Task<GetProductViewModel> IRequestHandler<GetProductByIdQuery, GetProductViewModel>.Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var viewModel = new GetProductViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Computer"
            };

           return Task.FromResult(viewModel);
        }
    }
}
