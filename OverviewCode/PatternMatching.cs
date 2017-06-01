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

            //talk about is. 


            /*
            var numberOfTimesIUsedJennysNumber = 8675309;
            
            switch (numberOfTimesIUsedJennysNumber)
            {

                
                ///case int noTimes when (true):
                ///    Console.WriteLine("always");
                ///break;
                
                case int noTimes when (
                    noTimes > 1
                    && noTimes < 10
                    ):
                    Console.WriteLine("No more than 10 times");
                break;

                case int noTimes when (
                    noTimes >= 10
                    && noTimes <= 100
                    ):
                    Console.WriteLine("No more than 100 times");
                    break;

                default:
                    Console.WriteLine("None at all?");
                    break;

            }*/


            string jennysNumber = null;


            if (jennysNumber is null)
            {
                Console.WriteLine("I am null!");
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





        }
    }
}
