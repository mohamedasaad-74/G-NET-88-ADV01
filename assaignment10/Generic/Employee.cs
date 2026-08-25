using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{
    #region Q8

   
    class Employee<T> where T : class
    {
        public T Details { get; set; }

        public Employee(T details)
        {
            Details = details;
        }
    #endregion
       
        

    }


}
    