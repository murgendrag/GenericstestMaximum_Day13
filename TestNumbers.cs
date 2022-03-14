using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericstestMaximum_Day13
{
    public  class TestNumbers
    {
        public void findMaximum()
        {
            const int a = 5;
            const int b = 9;
            const int c = 7;

            int ab = a.CompareTo(b);
            int ac = a.CompareTo(c);
            int ba = b.CompareTo(a);
            int bc = b.CompareTo(c);
            int ca = c.CompareTo(a);
            int cb = c.CompareTo(b);

            if (ab == 1 & ac == 1)
            {
                Console.WriteLine("a is largest" + a);
            }
            if (ba == 1 & bc == 1)
            {
                Console.WriteLine("b is largest number " + b);
            }
            if (ca == 1 & cb == 1)
            {
                Console.WriteLine("c is largest number" + c);
            }
        }
    }
}
