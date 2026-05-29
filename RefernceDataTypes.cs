

namespace CSharp_basics
{
    public class ReferenceDataTypes
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
        }
    }
}
