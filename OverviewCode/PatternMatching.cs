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


            var numberOfTimesIUsedJennysNumber = 8675309;
            
            switch (numberOfTimesIUsedJennysNumber)
            {

                case int noTimes when (
                    numberOfTimesIUsedJennysNumber > 1
                    && numberOfTimesIUsedJennysNumber < 10
                    ):
                    Console.WriteLine("No more than 10 times");
                break;

                case int noTimes when (
                        numberOfTimesIUsedJennysNumber >= 10

                        && numberOfTimesIUsedJennysNumber <= 100
                    ):
                    Console.WriteLine("No more than 100 times");
                    break;

                default:
                    Console.WriteLine("None at all?");
                    break;

            }
           

        }
    }
}
