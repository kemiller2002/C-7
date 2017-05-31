using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class ExpressionBodiedMembers
    {

        static void PrintName(string name) => Console.WriteLine(name);

        static void PrintNameWithNormalFunction(string name)
        {
            Console.WriteLine(name);
        }
    }
}
