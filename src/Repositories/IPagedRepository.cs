namespace WebPx.Repositories
{
    public interface IPagedRepository<TEntity, TKey> : IKeyedRepository<TEntity, TKey>,
        IRepositoryPagedList<TEntity>
    {
    }
}
