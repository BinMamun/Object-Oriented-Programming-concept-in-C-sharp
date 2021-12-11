using LINQ_Queries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> product = new List<Product>
            {
                new Product {ProductId = 101, ProductName = "Road-150 Black", Color = "Black",StandardCost = 1898.0944 ,ListPrice = 3374.99,ProductCategoryID= 1,ProductModelID =1 },
                new Product {ProductId = 102, ProductName = "Road-150 Black", Color = "Black", StandardCost = 1898.0944 ,ListPrice = 3374.99,ProductCategoryID= 1, ProductModelID =1 },
                new Product {ProductId = 103, ProductName = "Road-150 Silver", Color ="Silver", StandardCost = 598.4354 ,ListPrice = 3374.99,ProductCategoryID=2,ProductModelID= 2},
                new Product {ProductId = 104 ,ProductName = "Road-450 Red", Color = "Red",StandardCost = 1518.7864 ,ListPrice = 3374.99,ProductCategoryID= 2, ProductModelID = 2},
                new Product {ProductId = 105, ProductName = "Road-650 Red", Color = "Red", StandardCost = 1518.7864 , ListPrice = 3374.99,ProductCategoryID=3,ProductModelID= 3},
                new Product {ProductId = 106, ProductName = "Honda Hornet", Color = "Yellow",StandardCost = 185.8193,ListPrice = 3374.99,ProductCategoryID=3,ProductModelID= 3},
                new Product {ProductId = 107, ProductName = "Yamaha MT 15", Color = "Brown",StandardCost = 185.8193 ,ListPrice = 3374.99,ProductCategoryID=1, ProductModelID = 1},
                new Product {ProductId = 108, ProductName = "Yamaha SZ-RR V2", Color = "Pink",StandardCost = 598.4354, ListPrice = 3374.99,ProductCategoryID=2, ProductModelID = 2},
                new Product {ProductId = 109, ProductName = "Yamaha YZF-R1M", Color = "White",StandardCost = 598.4354,ListPrice = 3374.99,ProductCategoryID=3, ProductModelID = 3},
                new Product {ProductId = 110, ProductName = "Yamaha YZF R15", Color = "Blue",StandardCost = 1898.0944, ListPrice = 3374.99,ProductCategoryID=3, ProductModelID = 3},
                
            };

            List<ProductModel> model = new List<ProductModel>
            {
                new ProductModel {ProductModelID = 1, Name = "Classic Vest"},
                new ProductModel {ProductModelID = 2, Name = "Cycling Cap"},
                new ProductModel {ProductModelID = 3, Name = "Full-Finger Gloves"}
            };

            List<ProductCategory> category = new List<ProductCategory>
            {
                new ProductCategory {ProductCategoryID = 1, Name = "Components"},
                new ProductCategory {ProductCategoryID = 2, Name = "Clothing"},
                new ProductCategory {ProductCategoryID = 3, Name = "Accessories"},
                new ProductCategory {ProductCategoryID = 5, Name = "Mountain Bikes"},

            };

            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ////inner join
            Console.WriteLine("====================inner join===================");
            Console.WriteLine();
            var inner = from p in product
                        join m in model on p.ProductModelID equals m.ProductModelID
                        join cat in category on p.ProductCategoryID equals cat.ProductCategoryID
                        select new { p.ProductName, p.Color, p.ListPrice, Model = m.Name, Catagory = cat.Name };

            foreach (var v in inner)
            {
                Console.WriteLine($"Name: {v.ProductName.PadRight(10)}\t Color: {v.Color.ToString().PadRight(5)}\t" +
                    $"ListPrice: {v.ListPrice.ToString("0.00").PadLeft(10)},\t" +
                    $"  Model: {v.Model.PadRight(6)},\t  Catagory: {v.Catagory}");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            ////Left Outer Join
            Console.WriteLine("=========================Left Outer Join=====================");
            Console.WriteLine();
            var outer = from cat in category
                        join b in product on cat.ProductCategoryID equals b.ProductCategoryID into bcat
                        from cb in bcat.DefaultIfEmpty()
                        select new
                        {
                            Category = cat.Name.PadRight(10),
                            Name = cb == null ? "\"Not Listed\"" : cb.ProductName,
                            ListPrice = cb == null ? "\"No Price found\"" : cb.ListPrice.ToString("0.00"),
                            Color = cb == null ? "\"No Color found\"" : cb.Color.ToString()
                        };

            foreach (var v in outer)
            {

                Console.WriteLine($"Category: {v.Category}\t  Name: {v.Name.PadRight(15)},\t ListPrice: {v.ListPrice.PadLeft(15)},\tColor: {v.Color}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }//Main Method
    }//Program Class
}//NameSpace
