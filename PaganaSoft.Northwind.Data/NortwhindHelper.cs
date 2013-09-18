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

        public Product GetProductById(int ProdId)
        {
            using (var db = new NorthwindContext())
            {
                return db.Products.FirstOrDefault(p => p.ProductID == ProdId);
            }
        }

    }
}
