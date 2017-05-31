using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class ThrowExpressions
    {

        public void NotImplemented() => new NotImplementedException(); 


        public void OldNullCoalesce ()
        {
            var x = (true) ? 42 : 0;

            if(x == 0)
            {
                throw new Exception();
            }

        }

        public void OldNullCoalesceSecondChoice ()
        {
            var x = (true) ? 42 : new Func<int>(() => { throw new Exception(); })();
        }

        public void NullCoalesce ()
        {
            var x = (true) ? 42 : throw new NotImplementedException(); 
        }





    }
}
