﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverviewCode.Complete
{
    class ExpressionBodiedMembers
    {

        public ExpressionBodiedMembers() =>
                   Console.WriteLine("I am the constructor");

        ~ExpressionBodiedMembers() =>
            Console.WriteLine("I am the finalizer");


        static void PrintName(string name) =>
            Console.WriteLine(name);

        static void PrintNameWithNormalFunction(string name)
        {
            Console.WriteLine(name);
        }

        string _jennysPhoneNumber;
        public string JennysPhoneNumber
        {
            get => _jennysPhoneNumber;

            set => _jennysPhoneNumber = value;

        }
    }
}
