﻿using System;
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

        [TestMethod]
        public void CheapestProductTest()
        {
            var products = new Product[] { new Product("Book", (decimal)2.5), new Product("CD", (decimal)1.5), new Product("Mug", (decimal)0.75), new Product("Frame", (decimal)1), new Product("Magnet", (decimal)0.5) };
            Assert.AreEqual(products[4], FindCheapestProduct(products));
        }

        [TestMethod]
        public void MediumPriceTest()
        {
            var products = new Product[] { new Product("Book", (decimal)2.5), new Product("CD", (decimal)1.5), new Product("Mug", (decimal)0.75), new Product("Frame", (decimal)1), new Product("Magnet", (decimal)0.5) };
            Assert.AreEqual((decimal)1.25, CalculateMediumPrice(products));
        }

        [TestMethod]
        public void AddNewProductTest()
        {
            var products = new Product[] { new Product("Book", (decimal)2.5), new Product("CD", (decimal)1.5), new Product("Mug", (decimal)0.75), new Product("Frame", (decimal)1), new Product("Magnet", (decimal)0.5) };
            AddNewProduct(ref products);
            Assert.IsTrue(products[products.Length - 1].name == "Gift bag");
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
            decimal totalPayment = 0;
            for (int i = 0; i < products.Length; i++)
            {
                totalPayment += products[i].price;
            }
            return totalPayment;
        }

        Product FindCheapestProduct(Product[] products)
        {
            decimal cheapestProduct = products[0].price;
            int productIndex = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i].price < cheapestProduct)
                    productIndex = i;
            }
            return products[productIndex];
        }

        decimal CalculateMediumPrice(Product[] products)
        {
            decimal total = CalculateTotalPayment(products);
            return total / products.Length;
        }

        void AddNewProduct(ref Product[] products)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1].name = "Gift bag";
            products[products.Length - 1].price = (decimal)0.45;
        }
    }
}
