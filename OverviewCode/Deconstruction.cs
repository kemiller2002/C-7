using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{

    static class PersonAndPhoneNumberExtension
    {
        public static void Deconstruct(this NameAndPhoneNumer pAndN, out string person)
        {
            person = pAndN.Name;
        }

    }

    public class NameAndPhoneNumer
    {
        public string Name;
        public string PhoneNumer;

        public void Deconstruct(out string name, out string phoneNumber)
        {
            name = Name;
            phoneNumber = PhoneNumer;
        }

        public void Deconstruct(out string name)
        {
            name = Name;   
        }

    }

    class Deconstruction : IExample
    {
        public void ExecuteExample()
        {
            var jennysInfo = new NameAndPhoneNumer
            {
                Name = "Jenny",
                PhoneNumer = "867-5309"
            };

            var (name, _) = jennysInfo;

            //Console.WriteLine($"{jennysInfo}, {phone}");
        }
    }
}
