using LearningTool.Basics;
using LearningTool.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// "if" statement
            //    //Создаём новый объект
            //    Selections_if start_programm = new Selections_if();
            //    //Выполняем метод
            //    start_programm.Execute("something");

            //    // Или можно просто вызвать метод, как
            //    new Selections_if().Execute("false");
            ////
            // Task_1
            //new LeapYear().Execute();
            ////
            //// "switch" statement
            //new Selections_swich().Execute(3.ToString());
            ////
            //// ternary operator 
            //new Selections_if().PassWordCheck("parol");
            ////
            //// "while" Loop
            //Console.Write("Введите логин: ");
            //new Loops_while().Execute(Console.ReadLine());
            //// "DoWhile" Loop
            //new Loops_while().ExecuteDoWhole();
            //
            // for loop
            new Loops_for().Execute("");



        }
    }

}