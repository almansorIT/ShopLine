namespace Catalog.API.Products.CreateProduct;

using BuildingBlock.CQRS;
using Catalog.API.Models;

public record CreateProductCommand(
    string Name,
    List<string> Category,
    string Description,
    string ImageFile,
    decimal Price
) : ICommand<CreateProductCommandResponse>;

public record CreateProductCommandResponse(Guid Id);

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductCommandResponse>
{
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create entity
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            Price = command.Price,
            ImageFile = command.ImageFile
        };
        //save to database
        
        //return ProductResult
        return new CreateProductCommandResponse(Guid.NewGuid());
    }
}