using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    internal class Loops_for : MainClass
    {

        public override void Execute(string x)
        {
            for (int i = 0; i < 3; i++)
            {
                //  i -  видна только внутри тела цикла
                Console.WriteLine(i);
            }
            //Можно использовать без всех входных параметров
            for (;;) // при этом разделители должны оставаться
            {
                //тут получится бесконечный цикл
                Console.WriteLine("Выполняется цикл без входных параметров");
                //из такого цикла можно выйти с break
                break;
            }
            // с циклом можно рабоать с несколькими переменными вводя их через запятую
            // инкременты для перементов тоже можно вводить через запятую
            // добавить добалнительное условие можно добавить с помощью логических оператовор и/или
            for (string i = "1", j = "0"; i  != "100000" /*|| false */; i+=j) 
            {
                
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(200);
                
            }

        }
    }
}
