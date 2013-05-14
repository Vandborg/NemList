using ModelLayer;
using BusinessLayer;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLayer
{
    [TestClass]
    public class ProductListTest
    {
        [TestMethod]
        public void productConstructor()
        {
            //constructs a new list
            DateTime dateTime = DateTime.UtcNow;
            DateTime dateTime2 = dateTime.AddDays(5);
            ProductList productList = new ProductList("Jule shopping list", dateTime, dateTime2);
            Assert.AreEqual(
        }

        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}
