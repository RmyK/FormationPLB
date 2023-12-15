using System;

namespace ValVsRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a;
            short c= 6;
            long d = 16;
            Int64 e = 17;
            String str = "hello";
            string str2 = "world";

            a = 10;
            Console.WriteLine("Valeur de a :" + a);
            Console.WriteLine("Valeur de b :" + b);

            Test A = new Test();
            A.Value = 5;

            Test B = A;

            A.Value = 10;
            Console.WriteLine("Valeur de A :" + A.Value);
            Console.WriteLine("Valeur de B :" + B.Value);

            Console.Read();
        }
    }

    public class Test
    {
        public int Value;
    }
}
