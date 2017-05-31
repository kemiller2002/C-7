using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OverviewCode
{
    //	Install-Package System.ValueTuple -Pre


    class Tuples : IExample
    {
        public void ExecuteExample ()
        {

        }

        public ref string GetVtRef(ref string nameAndNumber)
        {
//            var nameAndNumber = "string"; //("jenny", "867-5309");

            return ref nameAndNumber; 

        }


    }
}
