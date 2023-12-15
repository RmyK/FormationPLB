using System;

namespace ConversionType
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            //var test = null;
            Test test2 = null;
            Test test3 = new ();

            var test4 = test ?? new();

            Console.WriteLine(test.ToString());

            string str = Console.ReadLine();

            bool isInt = int.TryParse(str,out int i);
            //int val = Convert.ToInt32(str);

            if(isInt)
            {
                Console.WriteLine("C'est une integer");
                Console.WriteLine("i a une valeur de :" + i);
            }
            else
            {
                Console.WriteLine("C'est une chaine de caractères");
            }

            Console.Read();

        }
    }

    class Test
    {
        int Value { get; set; }
    }
}
