using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class Ref : IExample
    {
        /*
        class NameAndPhoneNumber
        {
            public string Name { get; set; }
            public string PhoneNumber;
        }


        public void ExecuteExample()
        {
            var jennyPhoneNumber = new NameAndPhoneNumber
            {
                Name = "jenny",
                PhoneNumber = "867-5309"
            };

            ref var nameLocation = 
                ref GetNameLocation(ref jennyPhoneNumber);

            Capitalize(ref nameLocation);

            Console.WriteLine(jennyPhoneNumber.Name);
        }

        public ref char GetChar (string name)
        {
            return ref name[2];
        }



        ref string GetNameLocation(ref NameAndPhoneNumber nameAndPhoneNumber)
        {
            return ref nameAndPhoneNumber.Name;
        }

        void Capitalize(ref string word) => word = 
            word[0].ToString().ToUpper() + String.Join("", word.Skip(1));

    }*/

        /*
    public static ref char GetLocationOfFirstChar(char[] arr)
        => ref arr[0];


    public void ExecuteExample()
    {
        var jennysName = new[] { 'J', 'e', 'n', 'n', 'y' };

        ref char firstLetter = ref GetLocationOfFirstChar(jennysName);

        firstLetter = 'L';

        Console.WriteLine(jennysName);
    }
    */
        public void ExecuteExample()
        {
            throw new NotImplementedException();
        }
    }
}
