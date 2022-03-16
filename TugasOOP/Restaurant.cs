using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    public class Restaurant
    {
        static void Main(string[] args) {

            CustomerOrder customerOrder = new CustomerOrder();

            List<Product> productList = new List<Product>();
            productList.Add(new Product());
            productList.Add(new Product());
            productList.Add(new Product());
            productList.Add(new Product());

            productList[0].ProductName = "Nasi Goreng";
            productList[0].ProductPrice = 15000;
            productList[1].ProductName = "Mie Goreng";
            productList[1].ProductPrice = 17000;
            productList[2].ProductName = "Air Mineral";
            productList[2].ProductPrice = 5000;
            productList[3].ProductName = "Es Teh Manis";
            productList[3].ProductPrice = 5000;

            String optionOrder;
            do
            {

           
            Console.WriteLine($"Menu yang tersedia : ");
            Console.WriteLine(" ");
            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productList[i].ProductName} => {productList[i].ProductPrice}");
            }

            Console.WriteLine("===========================");
            Console.Write("Pilih Menu (Nomor):  ");
            int option = Convert.ToInt32(Console.ReadLine());   
          
            
            customerOrder.ProductOrder.Add(productList[option-1].ProductName);
            customerOrder.PriceOrder.Add(productList[option-1].ProductPrice);

                Console.Write("Pesan Menu Lain ? (Ya/Tidak) : ");
                optionOrder = Console.ReadLine();
            } while (optionOrder.Equals("ya"));

            int totalPrice = 0;
            for (int i = 0; i < customerOrder.ProductOrder.Count; i++)
            {
                Console.WriteLine($"Pesanan anda : {customerOrder.ProductOrder[i]}");
                totalPrice += customerOrder.PriceOrder[i];
            }
            Console.WriteLine($"Harga seluruh pesanan : {totalPrice}");
            

        }
    }
}
