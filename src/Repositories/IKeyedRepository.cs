namespace WebPx.Repositories
{
    public interface IKeyedRepository<TEntity, TKey> : IRepository<TEntity>
    {
        bool Delete(TKey key);
        TEntity Find(TKey key);
    }
}
