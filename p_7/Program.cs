using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_7
{
    using System;

    namespace StackExperiment
    {
        struct PointStruct
        {
            public int X;
            public int Y;
        }

        internal class Program
        {
            static int counter = 0;

            static void Main(string[] args)
            {
                try
                {
                    Recursion(10, includeExtraVars: true);
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine("Stack overflow occurred.");
                }
            }

            static void Recursion(int arraySize, bool includeExtraVars)
            {
                int[] arr = new int[1000];

                if (includeExtraVars)
                {
                    PointStruct p1, p2; //,p3, p4, p5, p6, p7, p8;
                }

                counter++;
                Console.WriteLine($"counter={counter}");

                Recursion(arraySize, includeExtraVars);
            }
        }
    }

}
