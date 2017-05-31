using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class Async
    {

       async Task<string> AsyncExample()
        {
            Task.Delay(10000);

            return "this is a test";
        }





    }
}
