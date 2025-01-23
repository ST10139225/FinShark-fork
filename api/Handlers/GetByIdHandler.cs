using api.Interfaces;
using api.Models;
using api.Queries;
using MediatR;

namespace api.Handlers
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuery, Stock>
    {
        private readonly IStockRepository _stockRepo;

        public GetByIdHandler(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }

        public async Task<Stock> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        { 

            var stock = await _stockRepo.GetByIdAsync(request.Id);

            if (stock == null)
            {
                
            }

            return stock;
        }
    }
}
