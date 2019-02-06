using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            MethodA();
        }
        public static void MethodA()
        {
            while (peanut())
            {
                Console.WriteLine("i am  struck in a infinite loop");
            }
        }
        public static bool peanut()
        {
            return true;
        }
    }
}
