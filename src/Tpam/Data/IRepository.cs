using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Tpam
{
    public interface IRepository<T> : IReadRepository<T>
    {
        Guid Save (T t);
        bool Update(Guid id, T t);
        bool Delete(T t);
    }

    public interface IReadRepository<T>
    {
        IEnumerable<T> Fetch();
        T Fetch(Guid key);
        IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
    }
}
