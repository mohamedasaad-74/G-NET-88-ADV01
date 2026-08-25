using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{

    #region Q7

    
    public class Salary<T> where T : struct
    {
        public T Amount { get; set; }

        public Salary(T initialAmount)
        {
            Amount = initialAmount;
        }
    }
}
    #endregion