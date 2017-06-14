using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void TotalPaymentTest()
        {
            var products = new Product[] { new Product("Book", (decimal)2.5), new Product("CD", (decimal)1.5), new Product("Mug", (decimal)0.75), new Product("Frame", (decimal)1), new Product("Magnet", (decimal)0.5) };
            Assert.AreEqual((decimal)6.25, CalculateTotalPayment(products));
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

        decimal CalculateTotalPayment( Product [] products)
        {
            return 0;
        }
    }
}
