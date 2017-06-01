using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class Async
    {

        async void DoANonReturningThing()
        {
        }

        async Task AsyncJustTask()
        {
            var  t =  new Task(Console.WriteLine);

            return; 
        }
        async Task<string> AsyncExample()
        {
            return "this is a test";
        }


        async ValueTask<int> NewValueTaskExample ()
        {
            return 42;
        }



    }
}
