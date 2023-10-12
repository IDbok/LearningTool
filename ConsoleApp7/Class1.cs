using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Class1
    {
        public void Execute()
        {
            object o = new object();
            o = 5;//"hello";
                  //string p = (string)o;

            //Приведение типов
            //
            //Оператор для проверки типов is
            if (o is object p) { Console.WriteLine(p); }
            else { Console.WriteLine("Не соответствует тип данных"); }

            //
            //Оператор для проверки типов as
            //object p2 = o as string;
            //if (p2 != null) { Console.WriteLine(p2); }
            //else { Console.WriteLine("Типы данных \"р2\" и \"о\" различны"); }

            //
            //Преобразование массивов
            //Int32[] arrInt = { 1, 2, 3, -4 };

            // преобразование в строку через объект не работает
            // string[] arrString = (System.String[])(System.Object)arrInt;

            //UInt32[] arrUInt = (UInt32[])(Object)arrInt;
            //Console.WriteLine(arrUInt[3]);// работет некорректно
        }



    }
}
