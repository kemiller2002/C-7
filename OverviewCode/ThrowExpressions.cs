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

            //show old ways
            //if exception 


            //func exception 


            //new way with ??


            
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
