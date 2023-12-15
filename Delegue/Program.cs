using System;
using System.Diagnostics;
using System.Threading;

namespace Delegue
{
    class Program
    {
        public delegate int Operation(int a, int b);

        public static Func<int, int, int> Opera;
        public static Action<int, int, int> Action;

        static void Main(string[] args)
        {
            var tictac = new TicTac();

            //tictac.Ontic += (sender, e) => { Console.WriteLine(((TicTac)sender).GetI()); };
            tictac.Ontic += DisplayI;

            var sw = new Stopwatch();

            sw.Start();

            while (true)
            {
                 if (sw.ElapsedMilliseconds >= 30000)
                    tictac.Ontic -= DisplayI;

                if (sw.ElapsedMilliseconds >= 35000)
                    break;

                Thread.Sleep(1000);
            }

            Console.WriteLine("Type Operation : 1 - Addition / 2 - Soustration / 3 - Division / 4 - Multiplication");
            var type = (TypeOperation)int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir operande A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir operande B");
            int b = int.Parse(Console.ReadLine());

            Operation ope = null;

            switch (type)
            {
                case TypeOperation.Addition:
                    ope = (int a, int b) => a + b;
                    break;
                case TypeOperation.Soustration:
                    ope = (int a, int b) => a - b;

                    break;
                case TypeOperation.Division:
                    ope = (int a, int b) => a / b;

                    break;
                case TypeOperation.Multiplication:
                    ope = (int a, int b) => a * b;

                    break;
                default:
                    break;
            }



            //Operation ope2 = (a, b) => a + b;

            //Opera = Additon;
            //Opera = (a, b) => a - b;

            Console.WriteLine(ope(a, b));
            //Console.WriteLine(Opera(a, b));
        }

        public static int Additon(int a, int b) => a + b;

        public static int Soustration(int a, int b)
        {
            return a - b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        enum TypeOperation
        {
            Addition = 1,
            Soustration,
            Division,
            Multiplication
        }

        public static void DisplayI(object? sender, EventArgs e)
        {
            Console.WriteLine(((TicTac)sender).GetI());
        }
    }
}
