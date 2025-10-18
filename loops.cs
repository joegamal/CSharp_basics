
using System.Diagnostics;

namespace basics
{
    public class loops
    {
        public static void Main()
        {
            //types of loops in C#

            //for loops
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("##########");

            //while loops
            int x = 0;
            while(x < 10)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("##########");

            //do while loops
            do
            {
                Console.WriteLine(x);
                x++;
            }while(x < 20);

            Console.WriteLine("##########");

            //foraech loop -> must iterate over an ittarable
            List<int> list = [111, 222, 333, 444, 555, 666, 777, 888, 999, 101010];
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }

}
