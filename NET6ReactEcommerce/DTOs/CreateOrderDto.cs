using NET6ReactEcommerce.Entities.OrderAggregate;

namespace NET6ReactEcommerce.DTOs
{
    public class CreateOrderDto
    {
        public bool SaveAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}