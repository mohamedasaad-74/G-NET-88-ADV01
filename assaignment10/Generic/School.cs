using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{
    class School<T> where T : Member
    {
        public T Member { get; set; }

        public School(T member)
        {
            Member = member;
        }

        public void ShowMember()
        {
            Member.ShowName();
        }
    }
}