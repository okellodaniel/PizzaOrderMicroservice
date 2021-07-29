using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandCenter.Infrastructure
{
    public class Dtos
    {
        public record OrderDto(Guid Id, string Adress, int Quantity, DateTimeOffset CreatedTable);
        public record CreateOrderDto([Required] string Adress, [Range(0, 1000)] int Qunatity);
        public record UpdateOrderDto([Required] string Adress, [Range(0, 1000)] int Qunatity);
    }
}