using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace OverviewCode
{
    class LocalFunctions : IExample
    {
        public void ExecuteExample()
        {
            //var beatleListing = GetBeatlesNames(5);

            //beatleListing.ToList().ForEach(Console.WriteLine);

            try
            {
                
                IEnumerable<string> beatlesNames = GetBeatlesNamesWithEnumerator(5);

                var firstBeatle = beatlesNames.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {

                IEnumerable<string> beatlesNames = GetBeatlesNames(5);

                var firstBeatle = beatlesNames.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        IEnumerable<string> GetBeatlesNamesWithEnumerator(int number)
        {
            var beatles = "george,john,paul,ringo".Split(',');

            if (number > 4) { throw new ArgumentException(); }

            for (int ii = 0; ii < number; ii++)
            {
                yield return beatles[ii];
            }

        }

    
        IEnumerable<string> GetBeatlesNames (int number)
        {
            var beatles = "george,john,paul,ringo".Split(',');

            if(number > 4) { throw new ArgumentException(); }

            IEnumerable<string> enumerateItem ()
            {
                for (int ii = 0; ii < number; ii++)
                {
                    yield return beatles[ii];
                }
            }

            return enumerateItem();

        }


        /*public static void ShowLocalMethod() =>
            typeof(LocalFunctions).GetMethods(BindingFlags.Static | BindingFlags.NonPublic)
                .Select(f => f.Name).ToList().ForEach(Console.WriteLine);
                
        public void ShowLocalMethod ()
        {
            var methods = typeof(LocalFunctions).GetMethods();
            //BindingFlags.Static | BindingFlags.NonPublic
            var ms = methods.ToList();

        }
        */
    }
}
