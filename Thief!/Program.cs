using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Thief_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the 4 digits you wish to see all possible combinations of.");
            int i;
            while(int.TryParse(Console.ReadLine(), out i) == false || (i.ToString().Length == 4) == false)
            {
                Console.WriteLine("Please enter the 4 digits you wish to see all possible combinations of.");
            }
            string one = i.ToString()[0].ToString();
            string two = i.ToString()[1].ToString();
            string three = i.ToString()[2].ToString();
            string four = i.ToString()[3].ToString();
            Console.WriteLine(one + two + three + four);
            Console.WriteLine(one + two + four + three);
            Console.WriteLine(one + three + two + four);
            Console.WriteLine(one + three + four + two);
            Console.WriteLine(one + four + two + three);
            Console.WriteLine(one + four + three + two);
            Console.WriteLine(two + one + three + four);
            Console.WriteLine(two + one + four + three);
            Console.WriteLine(two + three + one + four);
            Console.WriteLine(two + three + four + one);
            Console.WriteLine(two + four + one + three);
            Console.WriteLine(two + four + three + one);
            Console.WriteLine(three + one + two + four);
            Console.WriteLine(three + one + four + two);
            Console.WriteLine(three + two + one + four);
            Console.WriteLine(three + two + four + one);
            Console.WriteLine(three + four + one + two);
            Console.WriteLine(three + four + two + one);
            Console.WriteLine(four + one + two + three);
            Console.WriteLine(four + one + three + two);
            Console.WriteLine(four + two + one + three);
            Console.WriteLine(four + two + three + one);
            Console.WriteLine(four + three + one + two);
            Console.WriteLine(four + three + two + one);
            Console.Read();
        }
    }
}