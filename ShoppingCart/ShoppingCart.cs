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
            return books.Sum(x=>x.UnitPrice) * GetDiscount(books.Count);
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
                default:
                    throw new ArgumentException("Invaild argument count: " + count);
            }
        }
    }
}
