using dotnetLib;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.CurrentTimeMillis());
            Console.WriteLine(DateTime.Now.CurrentTimeSeconds());
            Console.WriteLine(DateTime.Now.CurrentTimeSeconds());
            Console.WriteLine(DateTimeUtils.StampToDateTime(DateTime.Now.CurrentTimeSeconds().ToString()));
            Console.WriteLine("Hello World!");
        }
    }
}
