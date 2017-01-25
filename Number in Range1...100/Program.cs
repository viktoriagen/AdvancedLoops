using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_in_Range1._._._100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number in the range[1...100]:");
            var n = int.Parse(Console.ReadLine());
            while (n <= 0 || n >100)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Enter a number in the range[1...100]:");
                n = int.Parse(Console.ReadLine());
            }
            if (n > 0 && n <= 100)
            {
                Console.WriteLine("The number is: {0}", n);
            }
        }
    }
}


