using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PaganaSoft.Northwind.Data.Models;

namespace PaganaSoft.Northwind.Data
{
    public class NorthwindHelper
    {
        public IQueryable<Product> GetProductsByCategory(int CatId)
        {
            using (var db = new NorthwindContext())
            {
                return db.Products.Where(c => c.CategoryID == CatId);
            }
        }

        /// <summary>
        /// Obtiene el producto con un ID especifico.
        /// </summary>
        /// <param name="ProdId"></param>
        /// <returns></returns>
        public Product GetProductById(int ProdId)
        {
            using (var db = new NorthwindContext())
            {
                return db.Products.FirstOrDefault(p => p.ProductID == ProdId);
            }
        }

        /// <summary>
        /// Obtiene un loistado de las categorias incluyendo sus productos.
        /// </summary>
        /// <returns></returns>
        public List<Category> GetCategories()
        {
            using (var db= new NorthwindContext())
            {
               return db.Categories.Include("Products").ToList();
            }
        }
        public List<Product> GetProducts()
        {
            using (var db = new NorthwindContext())
            {
                return db.Products.ToList();
            }
        }

        /// <summary>
        /// Funcion que regresa un IEnumerable de dynamic
        /// </summary>
        /// <returns><dynamic></returns>
        public dynamic GetProductsGrouped()
        {
            //using (var db = new NorthwindContext())
            //{

            var db = new NorthwindContext();
                return db.Products
                    .GroupBy(p => p.CategoryID)
                    .Select(s => new { Category = s.Key, Group = s }).ToList();
            //}
        }

        private void test()
        {
            var res = GetProductsGrouped();
            int IDCat = (int)res.Category;
        }
    }
}
