using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SuperPowers.EntityFramework.Repositories
{
    public abstract class SuperPowersRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SuperPowersDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SuperPowersRepositoryBase(IDbContextProvider<SuperPowersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SuperPowersRepositoryBase<TEntity> : SuperPowersRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SuperPowersRepositoryBase(IDbContextProvider<SuperPowersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
