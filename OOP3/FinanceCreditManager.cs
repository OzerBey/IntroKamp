using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class FinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("FinanceCredit plan was calculated. ");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
