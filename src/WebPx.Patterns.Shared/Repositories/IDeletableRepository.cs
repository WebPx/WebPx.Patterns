namespace WebPx.Repositories
{
    public interface IDeletableRepository<TEntity> : IRepository<TEntity>, IRepositoryDelete<TEntity>
    {

    }
}
