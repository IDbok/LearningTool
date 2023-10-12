using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    public abstract class MainClass1
    {
        // Абстрактный метод без реализации
        public abstract void Execute();
    }

    public class Subclass1 : MainClass1
    {
        public override void Execute()
        {
            // Реализация Execute для Subclass1
            Console.WriteLine("Выполнение для Subclass1");
        }
    }
}
