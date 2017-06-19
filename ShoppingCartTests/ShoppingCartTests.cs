using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}