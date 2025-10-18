using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_basics
{
    class A
    {
        protected string message = "from base class";

        public A()
        {
            Console.WriteLine("from A constructor");
        }
    }

    class B : A //A's constructor will be called automatically
    {
        public string GetMessage()
        {
            return message;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(int a, int b, int c)
        {
            return (a + b + c);
        }
    }


    class C : B //also A's constructor will be called automatically
    {
        public C()
        {
            Console.WriteLine("from C's constructor");
        }
    }

    public abstract class ABS
    {
        public string name = "abs";

        public string inherited()
        {
            return "from inherited method";
        }

        public abstract string must();
    }

    class D : ABS
    {
        public override string must()
        {
            return "must be implemented";
        }
    }

    public class Program
    {
        public static void Main()
        {
            B obj = new B();
            Console.WriteLine(obj.GetMessage()); //this will work
            //overloading
            obj.sum(2, 3);
            obj.sum(3, 4, 5);
             
            C ojb2 = new C();

            D obj3 = new D();
            Console.WriteLine(obj3.name);
            Console.WriteLine(obj3.inherited());
            Console.WriteLine(obj3.must());
        }
    }

}
