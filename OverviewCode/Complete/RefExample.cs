using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{

    class Ref : IExample
    {

        class NameAndPhoneNumber
        {
            public string Name;
            public string PhoneNumber;
        }


        public void ExecuteExample()
        {
            var jennyPhoneNumber = new NameAndPhoneNumber
            {
                Name = "jenny",
                PhoneNumber = "867-5309"
            };

            ref var nameLocation = ref GetNameLocation(jennyPhoneNumber);

            Capitalize(ref nameLocation);

            Console.WriteLine(jennyPhoneNumber.Name);
        }


        ref string GetNameLocation(NameAndPhoneNumber nameAndPhoneNumber)
        {
            return ref nameAndPhoneNumber.Name;
        }

        void Capitalize(ref string word) => word = word[0].ToString().ToUpper() + String.Join("", word.Skip(1));


        //public static ref char GetLocationOfFirstChar (string name) => ref name[0];


    }
}
