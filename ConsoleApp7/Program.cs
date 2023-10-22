﻿using LearningTool.OOP;
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


            string[] productList = { "Молоко", "Сыр", "Йогурт", "Масло", "Айран" };
            double[] priceList = { 100, 400, 80, 160, 100 };
            string[] itemList = { "руб/шт", "руб/шт", "руб/шт", "руб/шт", "руб/шт" };

            string endWord = "end";
            string input;

            ProductCatalod(productList, priceList, itemList);

            do
            {
                Console.WriteLine($"Введите номер и ко-во товара через пробел (введите \"{endWord}\" чтобы закончить):");
                input = Console.ReadLine();
                int[] inputList = ParseInput(input);
                bool isInProduct = productList.Length > inputList[0];

                if (inputList[2] == 1 && isInProduct)
                {
                    AddToCart(productList[inputList[0]], priceList[inputList[0]], inputList[1]);
                    Console.WriteLine("Был добавлен: " + ShowLastCartItem());
                }
                else if (input != endWord) { Console.WriteLine("Некорректный ввод, повторите попытку"); }

            } while (input != endWord);

            ShowCart();
            Console.ReadLine();


        }


        static string[] productCartList = new string[100];
        static double[] priceCartList = new double[100];
        static int[] amountCartList = new int[100];
        static double[] totalPriceCartList = new double[100];
        static double tatalPriceCart = 0;
        static int cartItem = 0;
        public static void AddToCart(string product, double price, int count)
        {
            // TODO - проверить наличие в карзины продукта

            productCartList[cartItem] = product;
            priceCartList[cartItem] = price;
            amountCartList[cartItem] = count;
            totalPriceCartList[cartItem] = price * count;
            tatalPriceCart += totalPriceCartList[cartItem];
            cartItem++;
        }
        //public static int IsInCart(string x)
        //{
        //    int result = -1;
        //    if (productCartList.Contains(x)) { result = productCartList.IndexOf(x)}

        //    return result;
        //}
        public static int[] ParseInput(string input)
        {

            string[] parse = input.Split(' ');
            int[] output = { 0, 0, -1 };
            //bool parseOK = false;
            if (parse.Length == 2)
            {

                bool firstTry = int.TryParse(parse[0], out output[0]);
                bool secondTry = int.TryParse(parse[1], out output[1]);

                if (firstTry && secondTry)
                {
                    output[2] = 1;
                }
            }
            return output;
        }

        public static string ShowLastCartItem()
        {
            return productCartList[cartItem - 1] + " " + amountCartList[cartItem - 1];
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
        public static void ShowCart()//string[] productCartList, double[] priceCartList, int[] amountCartList, double[] totalPriceCartList) 
        {
            Console.WriteLine("Состав корзины:");
            Console.WriteLine("Товар           Стоимость   Кол-во  Сумма");
            for (int i = 0; i < productCartList.Length; i++) 
            {
                if (priceCartList[i]==0)
                { 
                    break; 
                }
                Console.WriteLine($"{productCartList[i],-16} {priceCartList[i],-12} {amountCartList[i],-9} {totalPriceCartList[i],-5}");
            }
            Console.WriteLine($"Всего: {tatalPriceCart, 37}");
        }
    }

}