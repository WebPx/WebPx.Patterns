namespace WebPx.Repositories
{
    public interface IRepositoryDelete<TEntity> : IRepository
    {
        bool Delete(TEntity instance);
    }
}
