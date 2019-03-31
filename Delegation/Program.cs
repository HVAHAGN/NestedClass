using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    // Delegation technique.
    class A
    {
        public string DoSomething(string s)
        {
            //Console.WriteLine("Action");
            return s + " |||";
        }
    }
    class B
    {
        public string DoSomething(string s)
        {
            A a = new A();
           return  a.DoSomething(s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            string myShoes = b.DoSomething("Shoes to repair");
            Console.WriteLine(myShoes);
            Console.ReadLine();
        }
    }
}
