using System.Collections.Generic;

namespace WebPx.Repositories
{
    public interface IRepositoryPagedList<TEntity>
    {
        IEnumerable<TEntity> List(int startRowIndex, int maximumRows, out int totalRowCount);
    }
}
