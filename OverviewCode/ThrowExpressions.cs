using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode
{
    class ThrowExpressions : IExample
    {
        public void ExecuteExample()
        {
            var colorString = "red,green,blue".Split(',');

            var myGirlFriendsName = "Jenny" ?? throw new Exception();
        }

        public string MyFunction ()
        {
            throw new NotImplementedException();
        }
       

        public string GetName() {
            throw new NotImplementedException();
        }


    }
}
