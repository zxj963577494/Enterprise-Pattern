using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace IdentityMap.Repository
{
    public class IdentityMap<T>
    {
        Hashtable entities = new Hashtable();

        public T GetById(Guid id)
        {
            if (entities.ContainsKey(id))
            {
                return (T)entities[id];
            }
            else
            {
                return default(T);
            }
        }

        public void Store(Guid id, T entity)
        {
            if (!entities.ContainsKey(id))
            {
                entities.Add(id, entity);
            }
        }
    }
}
