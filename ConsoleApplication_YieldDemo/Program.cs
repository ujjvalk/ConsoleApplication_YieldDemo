using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_YieldDemo
{
    class Program
    {
        static List<long> Number = new List<long>();

        static List<long> SimpleLoop()
        {
            for (var i = 10000000; i < 20000000; i++)
            {
                Number.Add(i);
            }
            return Number;
        }

        static IEnumerable<long> YieldLoop()
        {
            foreach (long i in Number)
            {
                if (i % 2==0) 
                    yield return i;
            }
        }
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            SimpleLoop();
            IEnumerable<long> yieldNumbers = YieldLoop();
            foreach (var item in yieldNumbers)
            {
                Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); 
                Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); 
                Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); 
                Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); 
                Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); Console.Write(item); 
                Console.Write(item); Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
