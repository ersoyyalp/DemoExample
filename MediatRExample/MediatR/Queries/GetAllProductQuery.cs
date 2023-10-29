using MediatR;

namespace MediatRExample.MediatR.Queries
{
    public class GetAllProductQuery: IRequest<List<GetProductViewModel>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
        {
            public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model1 = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Computer"
                };
                var model2 = new GetProductViewModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "Phone"
                };

                return Task.FromResult(new List<GetProductViewModel>() { model1, model2 });

            }
        }
    }
}
