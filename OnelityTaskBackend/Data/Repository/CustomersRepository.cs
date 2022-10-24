using OnelityTaskBackend.Data;
using OnelityTaskBackend.Models;
using System.Linq.Expressions;
using OnelityTaskBackend.Interfaces;


namespace OnelityTaskBackend.Repository
{
    public interface ICustomersRepository : IGenericRepository<Customer>
    {
        IEnumerable<Customer> GetAll();
    }

    public class CustomersRepository : GenericRepository<Customer>, ICustomersRepository
    {
        private ApplicationDbContext _Context;

        public CustomersRepository(ApplicationDbContext context) : base(context)
        {
            this._Context = context;
        }


        public IEnumerable<Customer> GetAll()
        {
            var model = _context.Customer;

            return model;
        }

  
    }
}
