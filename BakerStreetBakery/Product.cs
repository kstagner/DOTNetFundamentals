using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    public enum BakeType
    {
        Bread, Cake, Pastery, Pie
    }
    public class Product
    {
        public string ProductName { get; set; }
        public string CustomerName { get; set; }
        public int OrderBatchSize { get; set; }
        public decimal OrderCost { get; set; }
        public BakeType Type { get; set; }

        public Product() { }

        public Product (string productname, string customername, int orderbatchsize, BakeType type, decimal ordercost)
        {
            ProductName = productname;
            CustomerName = customername;
            OrderBatchSize = orderbatchsize;
            OrderCost = ordercost;
        }




    }
}
