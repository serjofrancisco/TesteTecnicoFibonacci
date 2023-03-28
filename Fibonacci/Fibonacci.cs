using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTest
{
    public class Fibonacci
    {
        public int FibonacciFunc(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciFunc(n - 1) + FibonacciFunc(n - 2);
        }
    }
}
