using Microsoft.EntityFrameworkCore;
using Task_02_EF.Data;

namespace Task_02_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BikeStoresContext context = new BikeStoresContext();

            var categoiries= context.Categories.ToList();


            var firstProduct = context.Products.FirstOrDefault();

            int productId = 1;
            var specificProduct = context.Products.Find(productId);


            // Retrieve products with a certain model year
            int modelYear = 2023;
            var productsByYear = context.Products.Where(p => p.ModelYear == modelYear).ToList();



            // Retrieve a specific customer by ID
            int customerId = 1;
            var specificCustomer = context.Customers.Find(customerId);



        }
    }
}
