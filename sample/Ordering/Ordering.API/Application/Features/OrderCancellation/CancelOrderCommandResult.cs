using BareBones.CQRS;

namespace Ordering.API.Application.Features.OrderCancellation
{
    public class CancelOrderCommandResult
    {
        public int OrderId { get; set; }
    }


}
