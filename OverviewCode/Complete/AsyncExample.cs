using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class AsyncExample : IExample
    {
        public void ExecuteExample()
        {
            //Console.WriteLine(GetAsync().Wait());
        }


        public async ValueTask<String> GetAsync ()
        {
            throw new NotImplementedException();
        }


    }
}
