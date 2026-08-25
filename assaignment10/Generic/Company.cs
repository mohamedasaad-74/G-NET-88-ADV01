using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{

    #region Q10

    

    public class Company<T> where T : IComparable<T>
    {
        public int CompareItems(T item1, T item2)
        {
            return item1.CompareTo(item2);
        }
    }
}
    #endregion