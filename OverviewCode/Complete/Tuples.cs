using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class Tuples : IExample
    {
        public void ExecuteExample()
        {
            var nameAndPhone = ("jenny", "867-5309");

            var otherNameAndPhone  = ("jenny", "867-5309");

            var (name, phoneNumber) = nameAndPhone;

            var result = GetHerNameAndNumber();

            result.Name = "not jenny";

            Console.WriteLine(nameAndPhone.Equals(otherNameAndPhone));

        }


        public (string Name, string Phone) GetHerNameAndNumber ()
        {
            return ("jenny", "867-5300");

        }
    }
}
