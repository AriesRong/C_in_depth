using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace GenericMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = MakeList<string>("Line 1", "Line 2");
            foreach(string x in list)
            {
                Console.WriteLine(x);
            }
            List<int> number = MakeList<int>(5, 3);
            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
            Console.Read();
        }

        static List<T> MakeList<T>(T first,T second)
        {
            List<T> list = new List<T>();
            list.Add(first);
            list.Add(second);
            return list;
        }
    }
}
