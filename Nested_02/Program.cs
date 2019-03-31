using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_02
{
   class MyClass
    {
        private static int field = 0;
        public class Nested
        {
            public void Method(int a)
            {
                field = a;
                Console.WriteLine(field);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();
            instance.Method(2);

            Console.ReadLine();
        }
    }
}
