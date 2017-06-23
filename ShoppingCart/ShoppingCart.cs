using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        private readonly Dictionary<int, decimal> _disconnectRate = new Dictionary<int, decimal>
        {
            { 1, 1m },
            { 2, 0.95m },
            { 3, 0.9m },
            { 4, 0.8m },
            { 5, 0.75m },
        };

        public decimal CalculatePrice(List<Book> books)
        {
            var totalPrice = CalculateDiscountPrice(GetDiscountBooks(books));
            var remainBooks = GetRemainBooks(books);
            while (remainBooks.Count > 0)
            {
                totalPrice += CalculateDiscountPrice(remainBooks);
                remainBooks = GetRemainBooks(remainBooks);
            }
            return totalPrice;
        }

        private decimal CalculateDiscountPrice(List<Book> discountBooks)
        {
            return discountBooks.Sum(x => x.UnitPrice) * _disconnectRate[discountBooks.Count];
        }

        private List<Book> GetDiscountBooks(List<Book> books)
        {
            return books.GroupBy(x => x.Id).Select(x => x.First()).ToList();
        }

        private List<Book> GetRemainBooks(List<Book> books)
        {
            books.ForEach(x => x.Quantity--);
            return books.Where(x => x.Quantity >= 1).ToList();
        }
    }
}
