using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            Console.WriteLine(num1);

            Console.Write("what name?: ");
            string name = Console.ReadLine();

            Console.Write("what age?: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello {0}, you are {1} years old today",name,age);
            Console.ReadLine();
                

            

        }
    }
}
