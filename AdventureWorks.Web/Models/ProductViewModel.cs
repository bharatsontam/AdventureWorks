using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorks.Web.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {

        }
        public int ProductID { get; set; }
        public string ProductNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductCategory { get; set; }
        public string ProductSubcategory { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal? Weight { get; set; }
        public decimal ListPrice { get; set; }
    }
}