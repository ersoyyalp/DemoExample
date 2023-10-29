using MediatR;

namespace MediatRExample.MediatR.Command
{
    public class CreateProductCommand:IRequest<Guid>
    {
        public String Name { get; set; }

        public int Quantity { get; set; }

        public Decimal Value { get; set; }

        public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, Guid>
        {
            public Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());
            }
        }
    }
}
