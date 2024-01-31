using System;

namespace Async_Parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var does = new DoClass();
            DisplayAsync(does);
            Console.WriteLine(does.DoSomethingTask());
            Console.WriteLine(does.DoSomething());
            Console.Read();
        }

        static async void DisplayAsync(DoClass does)
        {
            var res = await does.DoSomethingAsync();
            Console.WriteLine(res);
        }
    }
}
