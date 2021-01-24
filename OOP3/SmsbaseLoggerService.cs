using System;

namespace OOP3
{
    class SmsbaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("To Sms logged");
        }
    }
}
