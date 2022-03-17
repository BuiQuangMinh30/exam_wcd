using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EXAM_WAD.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public double QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public double UnitsInStock { get; set; }
        public double UnitsOnStock { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category category { get; set; }

    }
}