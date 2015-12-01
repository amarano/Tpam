using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tpam.Domain;

namespace Tpam
{
    public abstract class View<T> where T : EntityBase
    {
        protected IReadRepository<T> Repository { get; private set; }

        public View()
        {
            Serializer = o => Task.Factory.StartNew<string>(() => JsonConvert.SerializeObject(o));
        }

        public View(Func<T, Task<string>> serializer, Func<IEnumerable<T>, Task<string>> collectionSerializer)
        {
            Serializer = serializer;
            CollectionSerializer = collectionSerializer;
        }

        public View(Func<T, Task<string>> serializer)
        {
            Serializer = serializer;
            CollectionSerializer = async ts =>
            {
                var jsons = await Task.WhenAll(ts.Select(Serializer));
                return new JArray(jsons).ToString();
            };
        }

        protected virtual Func<T, Task<string>> Serializer { get; set; }
        protected virtual Func<IEnumerable<T>, Task<string>> CollectionSerializer { get; set; }
        protected async virtual Task<string> Present(T t)
        {
            return await Serializer(t);
        }

        protected async virtual Task<string> PresentMany(IEnumerable<T> ts)
        {
            return await CollectionSerializer(ts);
        }
    } 

    public class ReadOnlyView<T> : View<T> where T : EntityBase
    {
    }
}