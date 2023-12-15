using System;
using System.Reflection;

namespace DirectiveEtAttribut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

#if DEBUG
            Console.WriteLine("Je suis en mode débug");
#else
            Console.WriteLine("Je suis dans un autre mode");
#endif
#if Madirective
            Console.WriteLine("Je fais un traitement spécifique");
#endif

#if Madirective2
            Console.WriteLine("Traiement ++++");
#endif

            #region Ma Region
            Console.WriteLine("Traiement ++++");
            Console.WriteLine("Traiement ++++");
            Console.WriteLine("Traiement ++++");
            #endregion

            #region Attribut
            ClasseDeTest classeDeTest = new ClasseDeTest()
            {
                MyValue = 1,
                MyString = "un",
                MyString2 = "deux",
                MyString3 = "trois",
                MyString4 = "quatre"
            };


            Console.WriteLine(
                classeDeTest
                .GetType()
                .GetProperty(nameof(ClasseDeTest.MyString))
                .GetCustomAttribute<CustomVisibilityAttribute>()
                .Order
                );
            #endregion

        }
    }
}
