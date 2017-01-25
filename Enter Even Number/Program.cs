using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter even number:");
                var n = double.Parse(Console.ReadLine());

                while (n % 2 != 0)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter even number:");
                    n = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Even number entered: {0}", n);
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid number!");
                Console.Write("Enter even number:");
                var n = double.Parse(Console.ReadLine());
                while (n % 2 != 0)
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter even number:");
                    n = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Even number entered: {0}", n);
            }
            
        }
    }
}
