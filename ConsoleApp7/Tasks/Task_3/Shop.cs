using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks.Task_3
{
    internal class Shop
    {

        string[] productList = { "Молоко", "Сыр", "Йогурт", "Масло", "Айран" };
        double[] priceList = { 100, 400, 80, 160, 100 };
        string endWord = "end";
        bool newCart = true;

        public Shop(string[] productList, double[] priceList, string endWord)
        {
            this.productList = productList;
            this.priceList = priceList;
            this.endWord = endWord;

            ContactWithClient();
        }
        void ContactWithClient() 
        {
            Console.WriteLine("Добро пожаловать в наш магазин!");
            ShowProductCatalod();
            Console.WriteLine();
            
            WorkWithCart();
        }

        void ShowProductCatalod()
        {
            Console.WriteLine("Каталог товаров:");
            Console.WriteLine();
            Console.WriteLine("Номер Наименование:     Стоимость:");
            Console.WriteLine();
            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine($"{i,5} {productList[i],-17} {priceList[i],-4} {"руб/шт",-5}");
            }
        }

        void WorkWithCart()
        {
            Cart cart = new Cart();

            string input;
            do
            {
                Console.WriteLine($"Введите номер и ко-во товара через пробел (введите \"{endWord}\" чтобы закончить):");
                input = Console.ReadLine();

                int[] inputList = ParseInput(input);
                // Проверка удачного парсинга ввода
                bool goodParse = inputList[2] == 1;
                // Проверка наличия введённого элемента в списке продуктов
                bool isInProduct = productList.Length > inputList[0];
                
                if (goodParse && isInProduct)
                {
                    // TODO - не понял,как реализовать создание нового объекта класса
                    // Cart при условии newCart или выполнение действий над этим классом.
                    // Выдаёт ошибку, не существует в данном контексте
                    
                    cart.AddPtoduct(productList[inputList[0]], priceList[inputList[0]], inputList[1]);
                    Console.WriteLine("Был добавлен: " + cart.ShowLastItem());
                    
                }
                else if (input != endWord) { Console.WriteLine("Некорректный ввод, повторите попытку"); }

            } while (input != endWord);
            cart.Show();
        }

        static int[] ParseInput(string input)
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
    }
}
