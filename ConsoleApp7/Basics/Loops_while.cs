using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    internal class Loops_while : MainClass
    {
        public override void Execute(string userName)
        {
            string storedUserName = "admin";
            string storedPassword = "admin";
            byte countTries = 0;
            bool passCheck = false;
            if (userName == storedUserName)
            {

                while (countTries < 3 && !passCheck)
                {
                    passCheck = new Selections_if().PassWordCheck(storedPassword);
                    countTries++;
                }
                if (!passCheck && countTries == 3) { Console.WriteLine("Превышен лимит попыток. Попробуйдет ещё раз позже!"); }
            }
            else { Console.WriteLine("Данный пользователь не разегистрирован в системе."); }
        }

        public bool Execute2(string userName)
        {
            string storedUserName = "admin";
            string storedPassword = "admin";
            byte countTries = 0;
            bool passCheck = false;
            bool userCheck = userName == storedUserName;
            if (userCheck)
            {

                while (countTries < 3 && !passCheck)
                {
                    passCheck = new Selections_if().PassWordCheck(storedPassword);
                    countTries++;
                }
                if (!passCheck && countTries == 3) { Console.WriteLine("Превышен лимит попыток. Попробуйдет ещё раз позже!"); }
            }
            else { Console.WriteLine("Данный пользователь не разегистрирован в системе."); }
            return passCheck && userCheck;
        }

        public void ExecuteDoWhole() 
        {
            bool accsess =false;
            
            do 
            {
                Console.Write("Введите логин: ");
                string userName = Console.ReadLine();
                accsess = Execute2(userName);
            }
            while (!accsess);
        }
    }
}
