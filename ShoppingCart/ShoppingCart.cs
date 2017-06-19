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
            if (books.Count == 1)
            {
                return books[0].UnitPrice;
            }
            if (books.Count == 2)
            {
                return books.Sum(x => x.UnitPrice) * 0.95m;
            }
            return books.Sum(x => x.UnitPrice) * 0.9m;
        }
    }
}
