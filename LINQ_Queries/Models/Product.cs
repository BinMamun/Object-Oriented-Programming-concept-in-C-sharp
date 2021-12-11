using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries.Models
{
    public class Product
    {        
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }

    }//Product Class

}//NameSpace
