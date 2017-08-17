using NSPattern.Decorator.Repository;
using NSPattern.Repository;
using NSPattern.Decorator;
using Microsoft.EntityFrameworkCore;

namespace NSPattern.DataBase.EntityFrameworkCore.Decorator.Repository
{
    public abstract class EFRepositoryValidateDecoratorBase<TRepository, TEntity, TContext> 
        : RepositoryValidateDecoratorBase<TRepository, TEntity>
        where TRepository: IRepository<TEntity>, IDecorateable
        where TContext : DbContext
    {
        public TContext Context { get; set; }
    }
}