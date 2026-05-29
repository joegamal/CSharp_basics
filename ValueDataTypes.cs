using System;

namespace CSharp_basics
{
    public class datatypes
    {
        /// <summary>
        /// these are all value types in C#
        /// the tree as follows:-
        /// byte
        ///  - byte
        ///  - sbyte
        ///
        /// short
        ///  - short
        ///  - ushort
        ///
        /// int
        ///  - int
        ///  - uint
        ///
        /// long
        ///  - long
        ///  - ulong
        ///
        /// float
        ///  - float
        ///  - double
        ///  - decimal
        ///
        /// bool
        ///  - bool
        ///
        /// char
        ///  - char
        ///
        /// struct
        ///  - struct
        ///
        /// enum
        ///  - enum
        ///
        /// union
        ///  - union
        ///
        /// tuple
        ///  - tuple
        ///
        /// nullable
        ///  - nullable
        ///
        /// </summary>
        public static void Main()
        {

            Console.WriteLine("hello");

            //signed types
            sbyte small = -5;  //8bits range

            short short_int = -2; //16bit range

            int num = -50; //32bit range

            long big_num = -5000000000000L; //64bits range

            //unsigned types
            byte usmall = 5;

            ushort ushort_int = 2; //UInt16

            uint unum = 50;  //UInt32

            ulong ubig_num = 500000000000L; //UInt64

            //floating points

            float A = 5.5F; //the smallest floating type representation

            decimal B = 5.5M; //the middle floating point representation

            double C = 5.5D; //the biggest floating type representation

            Console.WriteLine(C);

        }
    }
}
