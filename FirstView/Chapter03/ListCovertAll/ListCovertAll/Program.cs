using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ListCovertAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            integers.Add(1);
            integers.Add(2);
            integers.Add(3);
            integers.Add(4);

            Converter<int, double> coverter = TakeSquareRoot;
            List<double> doubles = integers.ConvertAll<double>(coverter);

            foreach(double d in doubles)
            {
                Console.WriteLine(d);
            }
            Console.Read();
        }
        static double TakeSquareRoot(int x)
        {
            return Math.Sqrt(x);
        }
    }
}
