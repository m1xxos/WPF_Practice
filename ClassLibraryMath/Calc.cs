using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMath
{
    public class Calc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Max(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
