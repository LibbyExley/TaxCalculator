namespace TaxCalculator.Classes
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public bool ItemTaxable { get; set; }
        public bool ItemImported { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int StockLevel { get; set; }

        public Product(int productId, string productName, bool itemTaxable, bool itemImported, 
            decimal costPrice, decimal sellPrice, int stockLevel)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ItemTaxable = itemTaxable;
            this.ItemImported = itemImported;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
            this.StockLevel = stockLevel;
        }

        public decimal CalculateTax()
        {
            if (ItemTaxable && ItemImported)
            {
                return SellPrice * 0.3m;
            } 
            else if (ItemImported)
            {
                return SellPrice * 0.1m;
            }
            else if (ItemTaxable)
            {
                return SellPrice * 0.2m;    
            }
            else 
            {
                return 0;
            }
        }
    }
}