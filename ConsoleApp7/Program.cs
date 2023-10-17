using LearningTool.OOP;
using LearningTool.Basics;
using LearningTool.Tasks;
using LearningTool.Tasks.Task_2;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// "if" statement
            ////Создаём новый объект
            //Selections_if start_programm = new Selections_if();
            ////Выполняем метод
            //start_programm.Execute("something");

            //// Или можно просто вызвать метод, как
            //new Selections_if().Execute("false");
            ////
            //Task_1
            //new LeapYear().Execute();
            //
            // "switch" statement
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
            //new Loops_for().Execute("");

            //TestClass cl = new TestClass();

            //cl.x = 1;
            //cl.y = 2;

            //Console.WriteLine(cl.y);
            //Console.WriteLine(cl.x);

            Book book1 = new Book("Harry Potter and the Chamber of Secrets", "J.C. Rowling",1998,"will be later",372);
            book1.PrintDetails();

            Console.WriteLine("\n");

            Book book2 = new Book("Harry Potter and the Methods of Rationality","Elizer Yudkowsky",2010);
            book2.RateBook(5);
            book2.RateBook(1);
            book2.RateBook(5);
            book2.RateBook(5);
            book2.RateBook(5);
            book2.RateBook(5);
            book2.RateBook(5);

            book2.PrintDetails();

        }
    }

}