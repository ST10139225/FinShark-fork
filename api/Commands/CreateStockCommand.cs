using api.Dtos.Stock;
using api.Models;
using MediatR;

namespace api.Commands
{
    public class CreateStockCommand: IRequest<Stock>
    {
        public CreateStockRequestDto stockDto { get; }

        public CreateStockCommand(CreateStockRequestDto stockDto)
        {
            this.stockDto = stockDto;
        }
    }
}
