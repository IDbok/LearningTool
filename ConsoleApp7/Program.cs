using LearningTool.OOP;
using LearningTool.Basics;
using LearningTool.Tasks;
using LearningTool.Tasks.Task_2;
using LearningTool.Tasks.Task_3;

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

            //Author author1 = new Author("J.C.", "Rowling", "31.07.1965");
            //Console.WriteLine(author1);

            //Console.WriteLine("\n");

            //Author author2 = new Author("Elizer", "Yudkowsky", "11.09.1979");
            //Console.WriteLine(author1);

            //Console.WriteLine("\n");

            //Book book1 = new Book("Harry Potter and the Chamber of Secrets", author1.GetName(), 1998, "will be later", 372);
            //Console.WriteLine(book1);

            //Console.WriteLine("\n");

            //Book book2 = new Book("Harry Potter and the Methods of Rationality", author2.GetName(), 2010);
            //Console.WriteLine(book2);

            //Console.WriteLine("\n");

            //User user1 = new User("user1", "ased@asd.sad", book1, author1);
            //Console.WriteLine(user1);

            //Console.WriteLine("\n");

            //User user2 = new User("user2", "ased@asd.sad", book2, author2);
            //Console.WriteLine(user2);

            //User user3 = new User("user3", "user3@asd.sad", book1, author1);

            //Console.WriteLine("\nВсего зарегистрированно пользователей: " + User.GetUserCount().ToString());

            //new Loops_foreach().Execute();

            //string[] productList = { "Молоко", "Сыр", "Йогурт", "Масло", "Айран" };
            //double[] priceList = { 100, 400, 80, 160, 100 };
            //string[] itemList = { "руб/шт", "руб/шт", "руб/шт", "руб/шт", "руб/шт" };

            //string endWord = "end";
            //string input;

            //ProductCatalod(productList, priceList, itemList);

            //do
            //{
            //    Console.WriteLine($"Введите номер и ко-во товара через пробел (введите \"{endWord}\" чтобы закончить):");
            //    input = Console.ReadLine();

            //    Console.WriteLine(input);
            //} while (input != endWord);



        }


        static string[] productCartList = new string[100];
        static double[] priceCartList = new double[100];
        static int[] amountCartList = new int[100];
        static double[] totalPriceCartList = new double[100];
        static double tatalPriceCart = 0;
        static int cartItem = 0;
        public static void AddToCart(string product, double price, int count)
        {
            productCartList[cartItem] = product;
            priceCartList[cartItem] = price;
            amountCartList[cartItem] = count;
            totalPriceCartList[cartItem] = price*count;
            tatalPriceCart += totalPriceCartList[cartItem];
            cartItem++;
        }
        public static void ProductCatalod(string[] productList, double[] priceList, string[] itemList)
        {
            Console.WriteLine("Каталог товаров:");
            Console.WriteLine();
            Console.WriteLine("Номер Наименование:     Стоимость:");
            Console.WriteLine();
            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine($"{i,5} {productList[i],-16} {priceList[i],-4} {itemList[i],-5}");
            }
        }
    }

}