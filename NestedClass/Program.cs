using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    class MyClass
    {
        public class NestedClass
        {
            public void Method()
            {
                Console.WriteLine("Method from nested class");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass.NestedClass instance = new MyClass.NestedClass();
            instance.Method();

            Console.ReadLine();
        }
    }
}
