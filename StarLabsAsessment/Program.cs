using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarLabsAsessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Basket();

            var tshirt = new TShirt();
            tshirt.Name = "RedBat";
            tshirt.Size = "m";
            basket.Shirts.Add(tshirt);

            var golfer = new Golfer();
            golfer.Name = "Polo";
            golfer.Size = "s";
            basket.Shirts.Add(golfer);

            var fomalPants = new FormalPants();
            fomalPants.Name = "Denim";
            fomalPants.Size = "m";
            basket.Pants.Add(fomalPants);

            var jeans = new Jeans();
            jeans.Name = "Adidas";
            jeans.Size = "l";
            basket.Pants.Add(jeans);

            Console.WriteLine("Your total price is "+ basket.GetTotalPrice().ToString("c"));
            Console.ReadKey();

        }
    }
}
