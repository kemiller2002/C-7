using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{

    static class PersonAndPhoneNumberExtension
    {

        public static void Deconstruct(this PersonAndPhoneNumber pAndN, out string person)
        {
            person = pAndN.Name;
        }

    }

    class PersonAndPhoneNumber
    {
        public string Name;
        public string PhoneNumber;

        public PersonAndPhoneNumber(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public void Deconstruct(out string name, out string phoneNumber)
        {
            name = Name;
            phoneNumber = PhoneNumber;
        }
    }

    class Deconstruction : IExample
    {
        public void ExecuteExample()
        {
            var jenny = new PersonAndPhoneNumber("Jenny", "867-5309");

            var (name, phone) = jenny;

            Console.WriteLine($"{name}, {phone}");

        }
    }
}
