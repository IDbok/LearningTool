using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    // 1. Модификатор доступа в родительском классе, должен быть более доступным
    //      или равным модификаторам в производных классах (public-в любой части программы;
    //      protected - не доступны из вне класса; internal - только внутри сборки;
    //      protected internal - ;
    //      private - только внутри класса/структуры в которой был создан;
    //      private protected - ;
    public abstract class MainClass
    {
        public abstract void Execute(string x);
        
    }
}
