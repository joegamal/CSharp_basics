

namespace CSharp_basics
{
    public static class ReferenceDataTypes
    {
        /// <summary>
        /// these are all reference types in C#
        ///  -object
        ///  -string
        ///  -record
        ///  -class
        ///  -interface
        ///  -delegate
        ///  -collecions
        ///  -void
        /// </summary>
        public static void Main()
        {
            //this is a scope
            {
                int x = 10;
            }
            Console.WriteLine("x is not accessible here");

            A a = new() { x = 10 };

            A b = new() { x = 10 };

            bool res = a == b;

            Console.WriteLine(res); //false
            Console.WriteLine(a.Equals(b)); //false

        }

        class A
        {
            public int x;
        }
    }
}
