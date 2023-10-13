using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Basics
{
    internal class Selections_swich : MainClass
    {
        public override void Execute(string x)
        {
            switch ( x ) 
            {
                case "1":
                    Console.WriteLine("Входное значение: чисто 1");
                    break;
                case "2":
                    Console.WriteLine("Входное значение: чисто 2");
                    break;
                //
                // в данном случае при значении "3" и "abracadabra" выполняется один код
                //
                case "3": 
                case "abracadabra":
                    Console.WriteLine("Входное значение магическое");
                    break;
                default: 
                    Console.WriteLine("Входное значение неопределенно");
                    break;
            }
        }

        // switch очень полезно использовать с emun
        // TODO - осмыслить работу с emun через switch
        public void ExecuteEnum(NewEnum x) 
        {
            throw new NotImplementedException();
        }

        public enum NewEnum : byte // можно задать тип для содержащихся enum (долно быть что-то с числом)
        {
            RandomStuf1,        //присваивается значение 0 автоматически
            RandomStuf2 = 54,   // можно присвоить самостоятельно какие-то значения
            RandomStuf3         // следующее значение в списке присваивается +1 от номера придедущего
        }
    }
}
