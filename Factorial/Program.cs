using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fac = 1;

            do
            {
                fac = fac * n;
                n--;

            } while (n>1);
            Console.WriteLine(fac);

        }
    }
}
