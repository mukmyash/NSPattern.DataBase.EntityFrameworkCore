using NSPattern.DataBase.EntityFrameworkCore.Transaction;
using Microsoft.EntityFrameworkCore;
using NSPattern.DataBase.Transaction;
using NSPattern.DataBase.UnitOfWork;

namespace NSPattern.DataBase.EntityFrameworkCore.UnitOfWork
{
    public abstract class UnitOfWorkBase<TContext> : IUnitOfWork
        where TContext : DbContext
    {
        TContext Context { get; set; }

        public IDatabaseTransaction BeginTransaction(IsolationLevel level = IsolationLevel.ReadCommitted)
        {
            return new EntityDatabaseTransaction(Context, level);
        }
    }
}
