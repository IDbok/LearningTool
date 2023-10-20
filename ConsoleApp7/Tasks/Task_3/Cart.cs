using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks.Task_3
{
    internal class Cart
    {

        public static void ProductCatalod(string[] productList, double[] priceList, string[] itemList)
        {
            Console.WriteLine("Каталог товаров:");
            Console.WriteLine();
            Console.WriteLine($"Наименование:" + "     " + "Стоимость:");
            Console.WriteLine();
            for (int i = 0; i < productList.Length; i++)
            {
                Console.WriteLine($"{productList[i],-16} {priceList[i],-4} {itemList[i],-5}");
            }
        }
    }

}
