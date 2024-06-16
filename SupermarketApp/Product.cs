using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketApp
{
    public class Product 
    {
        public string Name {  get; set; }
       
        public float Quantity { get; set; }
        public double Price { get; set; }

        public static double percentage = 0.8;

        public Dictionary<string, string> DiscountsForProducts { get; } = new Dictionary<string, string> 
        { { "onion", "percentage" }, { "tomato", "3 for 10" }, { "chocolate", "1+1" }, { "garlic", "3 for 10" }, { "apple", "percentage" } };

        public Product(string productName,float productQuantity,double productPrice) 
        {
            this.Name = productName;
            this.Quantity = productQuantity;   
            if (this.DiscountsForProducts.Keys.Contains(this.Name))
            {
                switch (DiscountsForProducts[this.Name]) 
                    {
                    case "percentage":
                        {
                            this.Price = productPrice*percentage*productQuantity;
                            break;
                        }
                    case "3 for 10":
                        {
                            this.Price = CalculatingPriceThreeForTen(productQuantity,productPrice);                            
                            break;
                        }
                    case "1+1":
                        {
                            this.Price = CalculatingPriceOnePlusOne(productQuantity, productPrice);                            
                            break;
                        }
                    }
            }
            else 
            {
                this.Price = productPrice*productQuantity;
            }
           }

        private double CalculatingPriceOnePlusOne(float productQuantity, double productPrice)
        {
           if (productQuantity % 2 == 0 )
            {
                return productPrice*productQuantity/2;
            }
           else 
            {
                return productPrice*(productQuantity/2 + 1);
            }
        }

        private double CalculatingPriceThreeForTen(float productQuantity,double productPrice)
        {
            if (this.Quantity < 3)
            {
                return productPrice*productQuantity;
            }
            else
            {
                return (productQuantity / 3) * 10 + (productQuantity % 3) * productPrice;
            }
        }

        public bool IsLegal()
        {
            if ((this.Name.Length < 2) || (this.Name.Length > 25) || (this.Name.Any(char.IsDigit))||(this.Quantity<1)||(this.Quantity>1000)||
                (this.Price<1)||(this.Price>1000))
                return false;
            return true;          
        }
    }
}
