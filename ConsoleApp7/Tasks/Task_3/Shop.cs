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
        string[] itemList = { "руб/шт", "руб/шт", "руб/шт", "руб/шт", "руб/шт" };

        public Shop(string[] productList, double[] priceList, string[] itemList) 
        {
            this.productList = productList;// = { "Молоко", "Сыр", "Йогурт", "Масло", "Айран" };
            this.priceList = priceList;// = { 100, 400, 80, 160, 100 };
            this.itemList = itemList;// = { "руб/шт", "руб/шт", "руб/шт", "руб/шт", "руб/шт" };

        }

        public void AddToCart()
        { 
            
        }
    }
}
