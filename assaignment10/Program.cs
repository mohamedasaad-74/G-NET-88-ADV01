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

        }


    }
}
