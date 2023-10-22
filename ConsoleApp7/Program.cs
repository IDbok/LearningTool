using LearningTool.Tasks.Task_3;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] productList = { "Молоко", "Сыр", "Йогурт", "Масло", "Айран", "Матцони" };
            double[] priceList = { 100, 400, 80, 160, 100, 120 };
            
            Shop newShop = new Shop(productList, priceList, "yohoo");

        }

    }

}