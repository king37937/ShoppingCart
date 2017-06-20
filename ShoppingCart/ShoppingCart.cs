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
        public decimal CalculatePrice(List<Book> books)
        {
            var discountBooks = books.Select(x => new Book { Id = x.Id, Quantity = 1, UnitPrice = x.UnitPrice }).ToList();
            var remainBooks = books.Where(x => x.Quantity > 1).Select(x => new Book { Id = x.Id, Quantity = x.Quantity - 1, UnitPrice = x.UnitPrice }).ToList();
            var totalPrice = discountBooks.Sum(x => x.UnitPrice) * GetDiscount(discountBooks.Count);
            while (remainBooks.Count > 0)
            {
                totalPrice += remainBooks.Sum(x => x.UnitPrice) * GetDiscount(remainBooks.Count);
                remainBooks = remainBooks.Where(x => x.Quantity > 1).Select(x => new Book { Id = x.Id, Quantity = x.Quantity - 1, UnitPrice = x.UnitPrice }).ToList();
            }
            return totalPrice;
        }

        private decimal GetDiscount(int count)
        {
            switch (count)
            {
                case 1:
                    return 1m;
                case 2:
                    return 0.95m;
                case 3:
                    return 0.9m;
                case 4:
                    return 0.8m;
                case 5:
                    return 0.75m;
                default:
                    throw new ArgumentException("Invaild argument count: " + count);
            }
        }
    }
}
