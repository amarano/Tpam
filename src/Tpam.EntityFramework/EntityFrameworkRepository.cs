using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tpam.EntityFramework
{
    public class EntityFrameworkRepository<Tkey, T> : IRepository<T>, IReadRepository<T>
    {
        public EntityFrameworkRepository()
        {

        }

        bool IRepository<T>.Delete(T t)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IReadRepository<T>.Fetch()
        {
            throw new NotImplementedException();
        }

        T IReadRepository<T>.Fetch<TKey>(TKey key, Expression<Func<T, TKey>> keySelector)
        {
            throw new NotImplementedException();
        }

        TKey IRepository<T>.Save<TKey>(T t, Expression<Func<T, TKey>> keySelector)
        {
            throw new NotImplementedException();
        }

        bool IRepository<T>.Update<TKey>(T t, Expression<Func<T, TKey>> keySelector)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IReadRepository<T>.Where(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
