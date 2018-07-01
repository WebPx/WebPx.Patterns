using System;
using System.Collections.Generic;

namespace WebPx.Repositories
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity> : IRepository
    {
        bool Create(TEntity instance);
        bool Update(TEntity instance);
    }
}
