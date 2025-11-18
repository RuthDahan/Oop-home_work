using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_5
{
    using System;

    namespace Program
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                int number = 10;
                long factorial = MyMath.Factorial(number);
                Console.WriteLine($"{number}!={factorial}");
            }
        }

        static class MyMath
        {
            public static long Factorial(int number)
            {
                long result = 1;
                for (; number >= 1; number--)
                {
                    result *= number;
                }
                return result;
            }
        }
    }

}
