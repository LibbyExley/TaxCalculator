using System;
using TaxCalculator.Classes;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = CreateBasket();

            Console.WriteLine($"Expected: £26.69, Actual: £{basket.GetGoodsTotal()}");
            Console.WriteLine($"Expected: £7.797, Actual:  £{basket.GetTaxTotal()}");
            Console.WriteLine($"Expected: £34.487, Actual: £{basket.GetGrossTotal()}");
            Console.ReadLine();
        }

        static Basket CreateBasket()
        {
            var basket = new Basket();

            basket.AddItemToBasket(
                new Product(000, "Glass Bottle", true, true,
                    15.99m, 25.99m, 15));

            basket.AddItemToBasket(
                new Product(001, "Can of pop", false, false, 
                    0.20m, 0.70m, 2500));
            
            return basket;
        }
    }
}
