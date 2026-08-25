using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{
    public class Container<T>
    {
        private T _item;

        public void Add(T item)
        {
            _item = item;
        }

        public T Get()
        {
            return _item;
        }
    }
}