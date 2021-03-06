﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void CalculatePriceTest_Id_1_Quantity_1_should_return_100m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1,  Quantity = 1, UnitPrice = 100m }
            };
            var expected = 100m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_Quantity_1_1_should_return_190m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 1, UnitPrice = 100m }
            };
            var expected = 190m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_Quantity_1_1_1_should_return_270m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 1, UnitPrice = 100m }
            };
            var expected = 270m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_4_Quantity_1_1_1_1_should_return_320m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 4, Quantity = 1, UnitPrice = 100m },
            };
            var expected = 320m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_4_5_Quantity_1_1_1_1_1_should_return_375m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 4, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 5, Quantity = 1, UnitPrice = 100m },
            };
            var expected = 375m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_Quantity_1_1_2_should_return_370m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 2, UnitPrice = 100m }
            };
            var expected = 370m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_Quantity_1_2_2_should_return_460m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 2, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 2, UnitPrice = 100m }
            };
            var expected = 460m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_2_3_4_5_Quantity_1_2_3_4_5_should_return_1255m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 1, UnitPrice = 100m },
                new Book() { Id = 2, Quantity = 2, UnitPrice = 100m },
                new Book() { Id = 3, Quantity = 3, UnitPrice = 100m },
                new Book() { Id = 4, Quantity = 4, UnitPrice = 100m },
                new Book() { Id = 5, Quantity = 5, UnitPrice = 100m },
            };
            var expected = 1255m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculatePriceTest_Id_1_Quantity_10_should_return_1000m()
        {
            //arrange
            var target = new ShoppingCart();
            var books = new List<Book>
            {
                new Book() { Id = 1, Quantity = 10, UnitPrice = 100m },
            };
            var expected = 1000m;

            //act
            var actual = target.CalculatePrice(books);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}