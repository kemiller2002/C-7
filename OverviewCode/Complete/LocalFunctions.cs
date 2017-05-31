using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class LocalFunctions : IExample
    {
        public void ExecuteExample()
        {
            var beatleListing = GetBeatlesNames(5);


            WriteBeatlesName(beatleListing);
        }


        public void WriteBeatlesName(IEnumerable<string> names) => names.ToList().ForEach(Console.WriteLine);


        IEnumerable<string> GetBeatlesNames(int number)
        {

            if (number > 4 || number < 1)
            {
                throw new NotImplementedException($"number is outside range {number}");
            }

            IEnumerable<string> enumerateNames()
            {
                var beatles = "John,George,Paul,Ringo".Split(',');

                for (var ii = 0; ii < number; ii++)
                {
                    yield return beatles[ii];
                }

            }

            return enumerateNames();
        }


    }
}
