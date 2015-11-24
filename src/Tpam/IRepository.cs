using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tpam
{
    public interface IRepository<T> : IReadRepository<T>
    {
        TKey Save<TKey>(T t, Expression<Func<T, TKey>> keySelector);
        bool Update<TKey>(T t, Expression<Func<T, TKey>> keySelector);
        bool Delete(T t);

    }

    public interface IReadRepository<T>
    {
        IEnumerable<T> Fetch();
        T Fetch<TKey>(TKey key, Expression<Func<T, TKey>> keySelector);
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate); 
    }

    public class ReadRepositoryFacade<T, TKey> 
    {
        private readonly IReadRepository<T> _repository;
        private readonly Expression<Func<T, TKey>> _keySelector;

        public ReadRepositoryFacade(IReadRepository<T> repository, Expression<Func<T, TKey>> keySelector)
        {
            _repository = repository;
            _keySelector = keySelector;
        }

        public virtual IEnumerable<T> Fetch()
        {
            return _repository.Fetch();
        }

        public virtual T Fetch(TKey id)
        {
            return _repository.Fetch(id, _keySelector);
        }

    }

}
