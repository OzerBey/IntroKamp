using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class WhicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            //
            //


            Console.WriteLine("WhicleCredit plan was calculated. ");
        }

        public void DoAnything()
        {
            throw new NotImplementedException();
        }
    }
}
