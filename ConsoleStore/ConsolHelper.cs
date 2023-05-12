using ConsoleStore.DataModels;
using ConsoleStore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStore
{

    public class ConsolHelper
    {
        List<Category> Categorylist = new List<Category>();
        List<Product> ProductList = new List<Product>();
        private void RegisterCategory(Category CategoryInfo)
        {
            Categorylist.Add(CategoryInfo);
        }
        
        public void RegisterProduct(Product productInfo)
        {
            ProductList.Add(productInfo);
        }
        public List<Category> GetAllCategory()
        {
            return Categorylist;
        }
        public List<Product> GetAllProduct()
        {
            return ProductList;
        }
        public Category GetCategory(int id)
        {
            return Categorylist.FirstOrDefault(s => s.Id == id);
        }
        public void SetCategory()
        {
            var CategoryInfo = new Category();
            Console.WriteLine("Please Enter CategoryId:");
            CategoryInfo.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter CategoryName:");
            CategoryInfo.Name = Console.ReadLine();
            RegisterCategory(CategoryInfo);
        }
        public void SetProduct()
        {
            var ProductInfo = new Product();
            Console.WriteLine("Please Enter CategoryId:");
            ProductInfo.CategoryId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter ProductId:");
            ProductInfo.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter ProductName:");
            ProductInfo.Name = Console.ReadLine();
            Console.WriteLine("Please Enter ProductPrice:");
            ProductInfo.Price = Convert.ToDouble(Console.ReadLine());
            RegisterProduct(ProductInfo);

        }
        public void ReportCategory()
        {
            Console.WriteLine("All Category ....");
            var AllReportCategory = GetAllCategory();
            foreach (var item in AllReportCategory)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void ReportProduct()
        {
            Console.WriteLine("All Product ....");
            var AllReportProduct = GetAllProduct();
            foreach (var item in AllReportProduct)
            {
                Console.WriteLine(item.ToString() + " " + GetCategory(item.CategoryId).ToString());
            }
        }

    }
}
