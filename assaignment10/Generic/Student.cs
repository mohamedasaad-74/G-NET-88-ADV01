using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{

    #region Q11

   
    class Student : Member
    {
        public int Grade { get; set; }

        public Student(string name, int grade) : base(name)
        {
            Grade = grade;
        }

        public void ShowStudent()
        {
            ShowName();
            Console.WriteLine($"Grade: {Grade}");
        }
    }
}
    #endregion