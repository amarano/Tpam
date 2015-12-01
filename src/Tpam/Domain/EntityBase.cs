using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tpam.Domain
{
    public abstract class EntityBase 
    {
        public Guid Id { get; protected set; }
    }
}
