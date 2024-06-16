using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketApp
{
    public class Program
    {
         public static void Main(string[] args)
        {
            ShoppingCart victoryCart = new ShoppingCart();
            Product p1 = new Product("onion", 2, 20);
            Product p2 = new Product("meat", 2, 20);
            Product p3 = new Product("monion1", 2, 100);
            Product p4 = new Product("m", 2, 100);
            Product p5 = new Product("monionlargerthantwentyfivecharstocheck", 2, 100);
            Product p6 = new Product("carrot", 0, 100);
            Product p7 = new Product("yogurt", 1001, 100);
            Product p8 = new Product("butter", 2, 0);
            Product p9 = new Product("apple", 2, 2001);
            Product p10 = new Product("", -1, 100000);
            Product p11 = new Product("chocolate", 3, 5);

            victoryCart.AddProduct(p1);
            victoryCart.AddProduct(p2);
            victoryCart.AddProduct(p3);
            victoryCart.AddProduct(p4);
            victoryCart.AddProduct(p5);
            victoryCart.AddProduct(p6);
            victoryCart.AddProduct(p7);
            victoryCart.AddProduct(p8);
            victoryCart.AddProduct(p9);
            victoryCart.AddProduct(p10);
            victoryCart.AddProduct(p11);
            

            double totalPrice = victoryCart.GetTotalPrice();
        }
    }
}

