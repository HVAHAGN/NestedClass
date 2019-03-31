using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_05
{
    // External class inheritance from BaseClass does not apply to Nested.
    public class MyClass : BaseClass
    {
        public class Nested
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Method from nested class");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance1 = new MyClass();
            instance1.MethodFromBase();


            MyClass.Nested instance2 = new MyClass.Nested();

            instance2.MethodFromNested();


            Console.ReadLine();
        }
    }
}