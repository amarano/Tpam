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
        ConcurrentBag<T> _bag = new ConcurrentBag<T>();

        public InMemoryRepository(IEnumerable<T> objects)
        {
            _bag = new ConcurrentBag<T>(objects);
        }

        bool IRepository<T>.Delete(T t)
        {
            throw new NotImplementedException();
        }

        ReadRepositoryFacade<T, TKey> IReadRepository<T>.Facade<TKey>(Expression<Func<T, TKey>> keySelector)
        {
            throw new NotImplementedException();
        }

        RepositoryFacade<T, TKey> IRepository<T>.Facade<TKey>(Expression<Func<T, TKey>> keySelector)
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
