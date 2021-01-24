using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgagecredit plan was calculated. ");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
