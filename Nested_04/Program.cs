using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_04
{
    // Inheritance from BaseClass does not apply.
    public class MyClass
    {
        public class Nested : BaseClass
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
            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromBase();
            instance.MethodFromNested();


            Console.ReadLine();
        }
    }
}
