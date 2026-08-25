using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{

    #region Q3

    
    public class Pair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public void Display()
        {
            Console.WriteLine($"Key: {Key}, Value: {Value}");
        }
    }
}
    #endregion