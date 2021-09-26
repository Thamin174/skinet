using System.Collections.Generic;
using Core.Entities;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
        public string Id { get; set; }
        
        public List<BasketItem> Items {get; set;}
        public int? DeliveryMethodId { get; set; }
        public string ClientSecret { get; set; }
        public string PaymentIntentId { get; set; }
        
    }
}