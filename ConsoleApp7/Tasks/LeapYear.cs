using LearningTool.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks
{
    internal class LeapYear : MainClass
    {
        
        public override void Execute(string x = "2000")
        {
            Console.Write("Введите год в формате \"YYYY\":");
            string input = Console.ReadLine();

            bool isUInt = UInt32.TryParse(input, out uint year);

            if (isUInt) 
            {
                int countDays = 365;
                if (IsLeapYear(year)) { countDays = 366; }
                else {
                    Console.WriteLine("Количество деней: " + countDays.ToString());
                    while (IsLeapYear(year)==false) { year++; }
                    Console.WriteLine("Следующий высокосный год будет в " + year.ToString());
                }
                
            }
            else { Console.WriteLine("Ошибка.\nВведите год в правильном формате"); }

            
        }
        private bool IsLeapYear (uint year) 
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            else { return false; }

        }
    }
}
