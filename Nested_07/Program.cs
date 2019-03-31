using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_07
{
    /// <summary>
    ///Non-static classes can contain static Nested classes.
    /// </summary>
    /// 
    public class MyClass
    {
        public static class Nested
        {
            public static void StaticMethodFromNested()
            {
                Console.WriteLine("Static method from nested");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested.StaticMethodFromNested();

            
            Console.ReadLine();
        }
    }
}
