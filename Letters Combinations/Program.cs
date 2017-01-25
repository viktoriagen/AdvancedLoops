using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            char a1 = a[0];
            char b1 = b[0];
            char c1 = c[0];

            var count = 0;

            for (char i = a1; i <= b1; i++)
            {
                for (char j = a1; j <= b1; j++)
                {
                    for (char k = a1; k <=b1; k++)
                    {
                        if (i != c1 && j != c1 && k != c1)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
