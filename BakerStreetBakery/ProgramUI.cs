using System;
using System.Collections.Generic;

namespace BakerStreetBakery
{
    public class ProgramUI
    {
        ProductRepository _productRepo = new ProductRepository();

        public void Run()
        {
        }

        private void PrintList()
        {
            List<Product> products = _productRepo.GetProductList();

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.ProductName}\n" +
                    $"{product.Type}{product.CustomerName}{product.OrderCost}");
            }
        }
        private void AddOrderList()
        {
            Console.WriteLine("What would you like to order?\n" +
                    "1. Bread\n" +
                    "2. Cake\n" +
                    "3. Pastry" +
                    "4. Pie");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

            BakeType type = BakeType.Bread;
                switch (input)
                {
                    case 1:
                    type = BakeType.Bread;
                        break;
                    case 2:
                    type = BakeType.Cake;
                        break;
                    case 3:
                    type = BakeType.Pastery;
                        break;
                    case 4:
                    type = BakeType.Pie;
                        break;
                }
            decimal cost = _productRepo.CalculateProductOrder(type);
            Console.WriteLine("Enter amount of order here:");
            string breadAsString = Console.ReadLine();
            int bread = int.Parse(breadAsString);
            
            Product newProduct = new Product(productName, customerName, type, cost);
            _productRepo.AddProductToList(newProduct);
        }
    }   
}