using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_03
{
    class MyClass
    {
        private int field = 0;
        public class Nested
        {
            MyClass instance = new MyClass();
            public void Method(int a)
            {
                instance.field = a; //encapsulation not working in nested class
                Console.WriteLine(instance.field);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.Method(77);
            Console.ReadLine();
        }
    }
}
