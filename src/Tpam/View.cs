using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tpam
{
    public abstract class View<T>
    {
        protected IReadRepository<T> Repository { get; private set; }

        public View()
        {
            Serializer = o => Task.Factory.StartNew<string>(() => JsonConvert.SerializeObject(o));
        }

        public View(Func<T, Task<string>> serializer)
        {
            Serializer = serializer;
        }

        protected virtual Func<T, Task<string>> Serializer { get; set; }

        protected async virtual Task<string> Present(T t)
        {
            return await Serializer(t);
        }

        protected async virtual Task<string> PresentMany(IEnumerable<T> ts)
        {
            throw new NotImplementedException();
        }
    }
}
