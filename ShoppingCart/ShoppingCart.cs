using System;
using System.Collections.Generic;
using System.Linq;
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
            return books.Sum(x => x.UnitPrice) * 0.95m;
        }
    }
}
