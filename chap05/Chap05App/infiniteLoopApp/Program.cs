using System;

namespace infiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long idx = 0;
            for ( ; ; ) // 무한루프
            {
                Console.WriteLine($"idx = {idx++}");
            }
        }
    }
}
