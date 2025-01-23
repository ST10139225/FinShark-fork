using api.Interfaces;
using api.Mappers;
using api.Models;
using api.Queries;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api.Handlers
{
    public class GetAllStocksHandler : IRequestHandler<GetAllStockQuery, List<Stock>>
    {
        private readonly IStockRepository _stockRepo;

        public GetAllStocksHandler(IStockRepository stockRepo)
        {
            _stockRepo = stockRepo;
        }
        public async Task<List<Stock>> Handle(GetAllStockQuery request, CancellationToken cancellationToken)
        {
             
            var stocks = await _stockRepo.GetAllAsync(request.query);

            

            return stocks.ToList(); ;
        }
    }
}
