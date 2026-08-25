using assaignment10.Generic;

namespace assaignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //============================================
            //What is a generic class?

            // وبعد كدا احطلها النوع بتاعها لما اجي انده عليها default بعمل المتغيرات عندي من غير نوع بحطلها النوع ال 
            //Why use generics?
            //بنستخدمه لهدف عدم التكرار وسهوله الكود
            #endregion
            #region Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<string> stringContainer = new Container<string>();
            //stringContainer.Add("Welcome route !");
            //string text = stringContainer.Get();

            #endregion
            #region Q3:What are multiple type parameters? Write Pair<TKey, TValue>.
            //  generic بتييح ليا اني احط اكتر من نوع في ال 
            //Pair<string, int> studentGrade = new Pair<string, int>("mohamed", 99);
            //studentGrade.Display();
            #endregion
            #region Q4: What is a generic method? Write Swap<T> method.
            // الهدف منها عدم التكرار  generic داخل كلاس مش  generic عباره عن داله 
            //لا يشترط ان احنا نقولها النوع لانها بتتعرف عليه من نوع البراميتر اللي انا مباصيه ودا علي عكس الكلاس 
            //int x = 10, y = 20;
            //Utility.Swap(ref x , ref y);
            //Console.WriteLine($"x: {x}, y: {y}");
            #endregion
            #region Q5: Write a generic method FindMax<T> that finds maximum value
            //int max = Utility.FindMax(10, 20);
            //Console.WriteLine($"FindMax : {max}");
            #endregion
            #region Q6: What is a generic interface? Write IRepository<T>.   interface
            // وبنطبقه علي الكلاسات اللي هيا مشتركه فيه  interface اللي جوا  function بتاع ال  signature لل  generic  بنعمل 
            //وكل كلاس بقي يحط النوع اللي هو عايزه 
            //لازم نعرف النوع اثناء التنفيد زي الكلاس ةعكس الداله

            #endregion
            #region Q7: What is the 'struct' constraint? Write an example. 
            // value type ان نوع القيم لازم يكون  developer بنستخدمه لوضع قيود علي ال generic constrin هو عباره عن 
            //   Salary<int> basicSalary = new Salary<int>(90000);
            //   Console.WriteLine(basicSalary.Amount);

            #endregion
            #region Q8: What is the 'class' constraint? Write an example.
            //refrence type ان نوع القيم لازم يكون  developer بنستخدمه لوضع قيود علي ال generic constrin هو عباره عن 
          //  Employee<string> empName = new Employee<string>("mohamed");
          //  Console.WriteLine(empName.Details);
            #endregion
        }


    }
}
