using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);*/
            /*string x = (10).ToString();
            Console.WriteLine(x + 5);*/

            /*Console.WriteLine("Please Enter Your num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum = " + (num1 + num2));*/

            /*Console.WriteLine("Please Enter Your num1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your num2");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The Sum = " + (num1 + num2));*/

            int num1, num2;
            Console.WriteLine("Please Enter Your num1");
            Int32.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Please Enter Your num2");
            Int32.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("The Sum = " + (num1 + num2));

        }
    }
}
