using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    internal class Loops_foreach
    {
        int[] num = new int[4];

        public void Execute() 
        {
            int memberCount = 0;
            foreach (int i in num) 
            {
                Console.WriteLine("Индекс: " + memberCount);
                Console.WriteLine($"\nЗначение элемента {memberCount+1} в массиве: " + i);
                ChangeValue(memberCount, 10 + memberCount);
                Console.WriteLine("\n\tНовое значение: " + i);
                memberCount++;
            }
        }
        private void ChangeValue(int index, int newValue) 
        {
            num[index] = newValue;
        }
    }
}
