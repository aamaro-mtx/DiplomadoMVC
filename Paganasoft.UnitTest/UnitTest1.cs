using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaganaSoft.Northwind.Data;
using PaganaSoft.Northwind.Data.Models;

namespace Paganasoft.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteaProductGrouping()
        {
            NorthwindHelper helper = new NorthwindHelper();
            var variable = helper.GetProductsGrouped();
            //IQueryable<Product> lista = (IQueryable <Product>)variable;
            //Assert.IsNotNull(variable);
        }
    }
}
