using NSPattern.Decorator.Repository;
using NSPattern.Repository;
using NSPattern.Decorator;
using Microsoft.EntityFrameworkCore;

namespace NSPattern.DataBase.EntityFrameworkCore.Decorator.Repository
{
    public abstract class EFRepositoryExpressionValidateDecoratorBase<TRepository, TEntity, TContext>
        : RepositoryExpressionValidateDecoratorBase<TRepository, TEntity>
        where TRepository : IRepositoryExpression<TEntity>, IDecorateable
        where TContext : DbContext
    {
        public TContext Context { get; set; }
    }
}