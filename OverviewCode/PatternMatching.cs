using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class PatternMatching : IExample
    {

        const string jPHone = "867";

        public void ExecuteExample()
        {
            object jennysNumber = null; //"867-5309"; 

            if(jennysNumber is null )
            {
                Console.WriteLine("I am Null!");
            }

            
            switch (jennysNumber)
            {

                case int i when (i == 42):
                    Console.Write("found i");
                    break;
                case string s when (s == "867-5309"):
                    Console.WriteLine("Jenny's number!");
                    break;

                case Object s when (s is null):
                    Console.WriteLine("Is Null?");
                    break;
                
                    
               // case string s:
                //    Console.Write("yes it's a string");
               //     break;

                //case null:
                //    Console.WriteLine("Just null!");
                //    break;
               
                //default:
                //    Console.WriteLine("Default!");
                //    break;

            }
            


        }
    }
}
