using System.Collections.Generic;

namespace TaxCalculator.Classes
{
    public class Basket
    {
        public decimal currentBasketTotal = 0m;
        public List<Product> Items;

        public Basket()
        {
            this.Items = new List<Product>();
        }

        public void AddItemToBasket(Product item)
        {
            Items.Add(item);
        }

        public decimal GetGoodsTotal()
        {        
            decimal goodsTotal = 0m;

            foreach (var item in Items)
            {
                goodsTotal += item.SellPrice;
            }
            
            return goodsTotal;
        }

        public decimal GetTaxTotal()
        {
            decimal taxTotal = 0m;

            foreach (var item in Items)
            {
                taxTotal += item.CalculateTax();
            }
            
            return taxTotal;
        }

        public decimal GetGrossTotal() => GetGoodsTotal() + GetTaxTotal();
    }
}