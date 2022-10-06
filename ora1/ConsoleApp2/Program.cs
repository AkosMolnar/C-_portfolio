using System;

namespace ConsoleApp2
{
    class Program
    {
        class Test
        {
            static int a = 0;
            public Test()
            {
                Console.WriteLine(++a);
            }
            ~Test()
            {
                a--;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Test t = new Test();
            }
        }
    }
}
