using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool.Tasks.Task_3
{
    public class Cart
    {
        string[] productCartList = new string[100];
        double[] priceCartList = new double[100];
        int[] amountCartList = new int[100];
        double[] totalPriceCartList = new double[100];
        double tatalPriceCart = 0;
        int cartItem = 0;
        
        public Cart() 
        {

        }
        
        public void AddPtoduct(string product, double price, int count)
        {
            // TODO - проверить наличие в карзины продукта

            productCartList[cartItem] = product;
            priceCartList[cartItem] = price;
            amountCartList[cartItem] = count;
            totalPriceCartList[cartItem] = price * count;
            tatalPriceCart += totalPriceCartList[cartItem];
            cartItem++;
        }
        public string ShowLastItem()
        {
            return productCartList[cartItem - 1] + " " + amountCartList[cartItem - 1];
        }
        public void Show()
        {
            Console.WriteLine("Состав корзины:");
            Console.WriteLine("Товар           Стоимость   Кол-во  Сумма");
            for (int i = 0; i < productCartList.Length; i++)
            {
                if (priceCartList[i] == 0)
                {
                    break;
                }
                Console.WriteLine($"{productCartList[i],-16} {priceCartList[i],-12} {amountCartList[i],-9} {totalPriceCartList[i],-5}");
            }
            Console.WriteLine($"Всего: {tatalPriceCart,37}");
        }
    }

}
