using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test test = new Test();

            Object obj = test;

            Test test2 = (Test)obj;

            test2.Value = 4;
        }
    }

    class Test
    {
        public int Value { get; set; }
    }
}
