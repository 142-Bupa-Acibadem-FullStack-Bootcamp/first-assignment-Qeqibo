using System;

namespace Northwind.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
