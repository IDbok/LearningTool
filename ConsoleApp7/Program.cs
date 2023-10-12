using LearningTool.Basics;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создаём новый объект
            Selections_if start_programm = new Selections_if();
            //Выполняем метод
            start_programm.Execute(true);

            // Или можно просто вызвать метод, как
            new Selections_if().Execute(false);

        }
    }

}