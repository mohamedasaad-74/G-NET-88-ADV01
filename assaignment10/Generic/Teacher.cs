using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assaignment10.Generic
{
    #region Q11

   
    class Teacher : Member
    {
        public string Subject { get; set; }

        public Teacher(string name, string subject) : base(name)
        {
            Subject = subject;
        }

        public void ShowTeacher()
        {
            ShowName();
            Console.WriteLine($"Subject: {Subject}");
        }
    }
}
    #endregion