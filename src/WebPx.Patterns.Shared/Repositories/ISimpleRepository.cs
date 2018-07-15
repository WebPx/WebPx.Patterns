namespace WebPx.Repositories
{
    public interface ISimpleRepository<TEntity, TKey> : IKeyedRepository<TEntity, TKey>,
        IRepositoryList<TEntity>
    {
    }
}
