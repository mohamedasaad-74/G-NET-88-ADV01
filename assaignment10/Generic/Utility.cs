using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{
    #region Q4


    public class Utility
    {
        public static void Swap<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;

    #endregion

        }
        #region Q5

        
        public static T FindMax<T>(T X, T Y)
        {
            return Comparer<T>.Default.Compare(X, Y) > 0 ? X : Y;

        }
    }
#endregion

}
