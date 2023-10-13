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
            else if (x == false) 
            {
                Console.WriteLine("not true");
            }
            //else // Такой вариант исключён условием для входного параметра
            //{
            //    Console.WriteLine("Введено некорректное значение"); 
            //}
        }

        // Тернарный опратор "?:" (т.к. работает с тремя операндами)
        public bool PassWordCheck(string storedPassword) 
        {

            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            bool passCheck = password == storedPassword ? true : false;
            string output = !passCheck ? "Вы ввели неправильный пароль": "Добро пожаловать";
            Console.WriteLine(output);
            
            return passCheck;
            
        }
    }
}
