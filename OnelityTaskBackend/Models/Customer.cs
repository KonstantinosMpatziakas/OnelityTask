namespace OnelityTaskBackend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }

        public Customer()
        {
            //Purchases = new HashSet<Purchase>();
        }
    }
}
