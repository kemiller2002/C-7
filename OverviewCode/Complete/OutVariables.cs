using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class OutVariables : IExample
    {
        public void ExecuteExample()
        {
            var x = "42";


            if(int.TryParse(x, out int result))
            {
                Console.WriteLine($"The answer is: {result}");
            }


            Console.WriteLine($"This is not outside of the scope {result}");

        }


        /*
         
                public void ExecuteExample()
        {

            var phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("jenny", "867-5309");

            if(phoneBook.TryGetValue("jenny", out string phoneNumber))
            {
                Console.WriteLine("Found");
            }

            var phone = phoneBook.TryGetValue("jenny", out string pNumber) ? phoneNumber : "not found";

            Console.WriteLine(phoneNumber);

        }
         
         */

    }
}
