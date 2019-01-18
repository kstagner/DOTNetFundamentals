using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public class ProductRepository
    {
        private List<Product> _productList = new List<Product>();

        public void AddProductToList(Product newProduct)
        {
            _productList.Add(newProduct);
        }
        public List<Product> GetProductList()
        {
            return _productList;
        }
        public void RemoveProductFromList(Product newProduct)
        {
            _productList.Remove(newProduct);
        }
        public decimal CalculateProductOrder(BakeType type)
        {
            decimal orderTotal = 100m;
            switch (type)
            {
                case BakeType.Bread:
                    orderTotal += 500.01m;
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


            return orderTotal;
        }
    
    }

}
