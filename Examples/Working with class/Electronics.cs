using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Electronics : Product
    {
        int quantity;
        int percent;


        public override void Discount(int percent)
        {
            if (percent < 20)
                price = price * (percent / 100);
        }

        public void payable()
        {
            total = quantity * price;
            Console.WriteLine(total);
        }
    }
}
