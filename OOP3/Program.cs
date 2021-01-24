using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager financeCreditManager = new FinanceCreditManager();
            //financeCreditManager.Calculate();

            ICreditManager whicleCreditManager = new WhicleCreditManager();
            //whicleCreditManager.Calculate();

            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            ICreditManager soldierCreditManager = new SoldierCreditManager();

            Console.WriteLine("---------------");
            ApplicationManager applicationManager = new ApplicationManager(); // Basvuru manager
            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsbaseLoggerService() };
            applicationManager.DoApplication(new FinanceCreditManager(),loggers);//veya applicationManager.DoApplication(financeCreditManager)
            applicationManager.DoApplication(soldierCreditManager,new List<ILoggerService>() { new SmsbaseLoggerService(),new DatabaseLoggerService() });
            List<ICreditManager> credits = new List<ICreditManager>() {financeCreditManager,whicleCreditManager,mortgageCreditManager};
           // applicationManager.DoCreditInformation(credits);
        }
    }
}
 