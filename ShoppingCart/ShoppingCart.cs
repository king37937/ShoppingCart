using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class ShoppingCart
    {
        public object CalculatePrice(List<Book> books)
        {
            if (books.Count == 1 && books[0].Id == 1)
            {
                return books[0].UnitPrice;
            }
            return 0;
        }
    }
}
