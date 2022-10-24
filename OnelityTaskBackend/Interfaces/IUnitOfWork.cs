using OnelityTaskBackend.Data.Repository;
using OnelityTaskBackend.Repository;
using System;

namespace OnelityTaskBackend.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomersRepository Customers { get; }
        IPurchasesRepository Purchases { get; }

        int Complete();
    }
}
