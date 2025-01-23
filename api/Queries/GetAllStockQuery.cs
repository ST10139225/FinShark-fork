using api.Helpers;
using api.Models;
using MediatR;

namespace api.Queries
{
    public class GetAllStockQuery: IRequest<List<Stock>>
    {
        public QueryObject query { get; }
        public GetAllStockQuery(QueryObject query)
        {
            this.query = query;
        }
    }
}
