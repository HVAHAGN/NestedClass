using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_06
{
    //Static classes can contain non-static Nested classes.
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Static constructor MyClass");
        }
        public static void StaticMethod()
        {
            Console.WriteLine("Static method class MyClass");
        }
        public class Nested
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Method Nested Class");
            }
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromNested();

            Console.WriteLine(new string('-', 30));

            MyClass.StaticMethod();

            Console.ReadLine();
        }
    }
}
