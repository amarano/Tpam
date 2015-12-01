using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Concurrent;


namespace Tpam.Data
{
    public class InMemoryRepository<T> : IRepository<T>, IReadRepository<T>
    {
        bool IRepository<T>.Delete(T t)
        {
            return false;
        }

        IEnumerable<T> IReadRepository<T>.Fetch()
        {
            throw new NotImplementedException();
        }

        T IReadRepository<T>.Fetch(Guid key)
        {
            throw new NotImplementedException();
        }

        Guid IRepository<T>.Save(T t)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Update(Guid id, T t)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IReadRepository<T>.Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
