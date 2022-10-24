using OnelityTaskBackend.Models;
using OnelityTaskBackend.Repository;
using System.Linq.Expressions;

namespace OnelityTaskBackend.Data.Repository
{
    public interface IPurchasesRepository : IGenericRepository<Purchase>
    {
        IEnumerable<Purchase> GetAll();
    }
    public class PurchasesRepository : GenericRepository<Purchase>, IPurchasesRepository
    {
        private ApplicationDbContext _Context;
        public PurchasesRepository(ApplicationDbContext context) : base(context)
        {
            this._Context = context;
        }

        public IEnumerable<Purchase> GetAll()
        {
            var model = _context.Purchase;

            return model;
        }
    }
}
