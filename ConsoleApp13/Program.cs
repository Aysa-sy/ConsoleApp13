using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please ener a number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = calc(n);
            Console.WriteLine("product 5 numbers is:" + result);
        }

        static int calc(int n)
        {
            int p = 1;
            while (n > 0)
            {
                int aa = n % 10;
                if (aa > 5)
                {
                    p *= aa;
                }
                n /= 10;
            }
            return p;
        }
    }
}
