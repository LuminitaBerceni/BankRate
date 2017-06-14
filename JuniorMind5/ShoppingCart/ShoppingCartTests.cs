using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        struct Product
        {
            public string name;
            public decimal price;

            public Product (string name , decimal price)
            {
                this.name = name;
                this.price = price;
            }
        }
    }
}
