using api.Models;
using MediatR;

namespace api.Queries
{

    public class GetByIdQuery: IRequest<Stock>
    {
        public int Id { get; }

        public GetByIdQuery(int id)
        {
            Id = id;
        }
    }
}
