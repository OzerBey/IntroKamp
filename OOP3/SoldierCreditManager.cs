using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SoldierCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Soldiercredit plan was calculated.");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
