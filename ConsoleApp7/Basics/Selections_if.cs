using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    public class Selections_if : MainClass
    {
        public override void Execute(bool x) 
        {
            if (x) { Console.WriteLine("is true"); }
            else { Console.WriteLine("is false"); }
        }
    }
}
