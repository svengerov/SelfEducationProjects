using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketApp
{
    public class ShoppingCart 
    {
        
        public double TotalPrice { get; }
        public List<Product> _products { get; set; }
        public ShoppingCart() 
        {
            this.TotalPrice = 0;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product.IsLegal())
            {
                _products.Add(product);
            }
        }

        public double GetTotalPrice()
        {      
            double total = 0;
            double tax = 1.17;
                foreach (var product in _products) 
                {
                    total += product.Price;
                    Console.WriteLine($"Adding product {product.Name} with quantity {product.Quantity} and price {product.Price}");
                }
                return total*tax;
                }
        }
    }

