namespace Catalog.API.Products.CreateProduct;

using MediatR;
public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    decimal Price
) : IRequest<CreateProductCommandResponse>;

public record CreateProductCommandResponse(Guid Id);

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
{
    public Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Implementation for handling the creation of a product
        throw new NotImplementedException();
    }
}