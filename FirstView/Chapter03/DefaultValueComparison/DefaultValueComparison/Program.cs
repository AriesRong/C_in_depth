using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValueComparison
{
    class Program
    {
        static int CompareToDefault<T>(T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CompareToDefault("x"));
            Console.WriteLine(CompareToDefault(10));
            Console.WriteLine(CompareToDefault(0));
            Console.WriteLine(CompareToDefault(-10));
            Console.WriteLine(CompareToDefault(DateTime.MinValue));
            //Console.WriteLine(CompareToDefault(null));无法推断出T的类型参数

            Console.Read();
        }
    }
}
