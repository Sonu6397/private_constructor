using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_constructor
{ 
    class example
    {
        public static int a;
        private example()
        {
            
        }
        public static int Add()
        {
            return a;
        }

        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
     
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            example.getTime();
            example.a = 201;
            Console.WriteLine(example.Add());
            Console.ReadLine();
        }
    }
}
