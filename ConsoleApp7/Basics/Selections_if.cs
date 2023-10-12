using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    public class Selections_if : MainClass
    {
        public override void Execute(string someString) 
        {
            bool x;
            bool.TryParse(someString, out x);

            if (x == true) 
            {
                Console.WriteLine("is true"); 
            }
            else if ((Boolean)(Object)x == false) 
            {
                Console.WriteLine("not true");
            }
            //else // Такой вариант исключён условием для входного параметра
            //{
            //    Console.WriteLine("Введено некорректное значение"); 
            //}
        }
    }
}
