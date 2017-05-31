using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            var example = new PatternMatching();

            Execute(example);

            Console.WriteLine("Finished press <Enter> to end");
            Console.ReadLine();

        }

        static void Execute(IExample example)
        {
            example.ExecuteExample();
        }

    }
}
