using OnelityTaskBackend.Interfaces;
using OnelityTaskBackend.Data;
using OnelityTaskBackend.Repository;
using OnelityTaskBackend.Models;
using OnelityTaskBackend.Data.Repository;

namespace OnelityTaskBackend.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Customers = new CustomersRepository(_context);
            Purchases = new PurchasesRepository(_context);
        }

        public ICustomersRepository Customers { get; private set; }
        public IPurchasesRepository Purchases { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
