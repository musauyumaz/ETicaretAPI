using MediatR;

namespace ETicaretAPI.Application.Features.Queries.Order.GetAllOrder
{
    public class GetAllOrderQueryRequest : IRequest<GetAllOrderQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
