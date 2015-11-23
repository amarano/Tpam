using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tpam
{
    public abstract class View<T>
    {
        private readonly T _t;

        public View(T t)
        {
            _t = t;
            Serializer = o => Task.Factory.StartNew<string>(() => JsonConvert.SerializeObject(o));

        }

        public View(T t, Func<T, Task<string>> serializer) : this(t)
        {
            Serializer = serializer;
        }

        protected virtual Func<T, Task<string>> Serializer { get; set; }

        protected async virtual Task<string> Present()
        {
            return await Serializer(_t);
        }
    }
}
