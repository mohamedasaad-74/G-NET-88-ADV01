using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{

    #region Q9

   
    public class EmployeeFactory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
}
    #endregion