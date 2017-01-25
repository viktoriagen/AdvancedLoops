using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var temp = 0;

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                while (temp < 1)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            temp++;
                        }
                    }
                }
                if (temp > 1)
                {
                    Console.WriteLine("Not Prime");
                }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
