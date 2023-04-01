using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Product
    {
        public int price;
        public static int count = 0;
        public int total;
        public Product()
        {
            count++;
        }
        public virtual void Discount(int percent)
        {
            total = price - ((price * percent) / 100);
            Console.WriteLine(total);
        }
    }
}
