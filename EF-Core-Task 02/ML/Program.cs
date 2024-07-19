using Microsoft.EntityFrameworkCore;
using Task_02_EF.Data;

namespace Task_02_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStoresContext context = new BikeStoresContext();

            #region Retrieve all categories from the production.categories table.

            var Categoiries = context.Categories.ToList(); 

            foreach (var category in Categoiries)
                Console.WriteLine($"The Categoiries is {category} ");
            #endregion

            #region Retrieve the first product from the production.products table
            var FirstProduct = context.Products.FirstOrDefault();
            Console.WriteLine($"The First Product is {FirstProduct} ");
            #endregion

            #region Retrieve a specific product from the production.products table by ID.

            int productId = 1;
            var specificProduct = context.Products.Find(productId);
            Console.WriteLine($"The Product is {specificProduct}");
            #endregion

            #region Retrieve a specific product from the production.products table by ID.
            int ModelYear = 2021;
            var ProductsByYear = context.Products.Where(p => p.ModelYear == ModelYear).ToList();

            foreach (var product in ProductsByYear)
                Console.WriteLine($"The Product in 2021 is {product}");
            #endregion

            #region Retrieve a specific customer from the sales.customers table by ID.
            int CustomerId = 10;
            var specificCustomer = context.Customers.Find(CustomerId);

            Console.WriteLine($"The Customer is {specificCustomer}");
            #endregion

            #region Retrieve a list of product names and their corresponding brand names.

            var productNamesAndBrands = context.Products
           .Select(p => new { p.ProductName, p.Brand })
           .ToList();

            foreach (var product in productNamesAndBrands)
                Console.WriteLine($"The Products Name Is {product} "); 
            #endregion

            #region Count the number of products in a specific category.
            int CategoryId = 3;
            var ProductCountInCategory = context.Products
                .Count(p => p.CategoryId == CategoryId);
            Console.WriteLine($"The Number Of Product For Specfied Id is {ProductCountInCategory}"); 
            #endregion

            #region Calculate the total list price of all products in a specific category.

            var TotalListPriceInCategory = context.Products
                .Where(p => p.CategoryId == CategoryId)
                .Sum(p => p.ListPrice);
            Console.WriteLine($"The Total List Price Of All Products Is {TotalListPriceInCategory} "); 
            #endregion

            #region Calculate the average list price of products.
            var AverageListPrice = context.Products.Average(p => p.ListPrice);
            Console.WriteLine($"The Average List Price is {AverageListPrice}"); 
            #endregion

            #region Retrieve orders that are completed.
            var CompletedOrders = context.Orders
        .Where(o => o.OrderStatus == 4)
        .ToList();

            foreach (var order in CompletedOrders)
                Console.WriteLine($"The Completed Orders is {order}"); 
            #endregion

        }
    }
}
