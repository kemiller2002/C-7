using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class PatternMatching
    {
        public static void WriteIntRange(int i)
        {
            switch (i)
            {

                case int n when (n < 100):
                    Console.WriteLine($"I am above 100: {n}");
                    break;

                case int n when (n > 50):
                    Console.WriteLine($"I am above 100: {n}");
                    break;

                case int n when (n >= 100):
                    Console.WriteLine($"I am above 100: {n}");
                    break;

                case int n when (n < 100 && n >= 50):
                    Console.WriteLine($"I am between 100 and 50: {n}");
                    break;

                case int n when (n < 50):
                    Console.WriteLine($"I am between 100 and 50: {n}");
                    break;
            }
        }


        /*
         string jennysNumber = null; 

            if(jennysNumber is null)
            {
                Console.WriteLine("I am Null!");
            }

            
           switch (jennysNumber)
            {

                case string s when (s == "867-5309"):
                    Console.WriteLine("Jenny's number!");
                    break;

                case string s when (s is null):
                    Console.WriteLine("Is Null?");
                    break;
                    
                case string s:
                    Console.Write("yes it's a string");
                    break;

                case null:
                    Console.WriteLine("Just null!");
                    break;
               
                default:
                    Console.WriteLine("Default!");
                    break;

            }
         
         
         */

    }
}
