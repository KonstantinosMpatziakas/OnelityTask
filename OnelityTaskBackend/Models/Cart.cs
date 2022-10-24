namespace OnelityTaskBackend.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int PurchaseId { get; set; }
        public Customer Customer { get; set; }
        public Purchase Purchase { get; set; }  
    }
}
