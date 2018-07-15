using System.Collections.Generic;

namespace WebPx.Repositories
{
    public interface IRepositoryList<TEntity>
    {
        IEnumerable<TEntity> List(int startRowIndex, int maximumRows);
    }
}
