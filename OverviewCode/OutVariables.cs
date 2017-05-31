using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class OutVariables : IExample
    {
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
    }
}
