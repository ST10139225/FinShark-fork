using api.Commands;
using api.Dtos.Stock;
using api.Interfaces;
using api.Mappers;
using api.Models;
using MediatR;

namespace api.Handlers
{
    public class CreateStockHandler : IRequestHandler<CreateStockCommand, Stock>
    {
        private readonly IStockRepository _stockRepo;

        public CreateStockHandler(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }

        public Task<Stock> Handle(CreateStockCommand request, CancellationToken cancellationToken)
        {
            

            var stockModel = request.stockDto.ToStockFromCreateDTO();

             var result=  _stockRepo.CreateAsync(stockModel);

            return result;
             
        }
    }
}
