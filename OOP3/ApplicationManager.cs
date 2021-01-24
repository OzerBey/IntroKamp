using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager //Basvuru Yönetimi
    {
        //Method injection
        public void DoApplication(ICreditManager creditManager,List<ILoggerService> loggerServices) // Hepsinin referansını tuttugu için IcreditManager interfaceni kullanıyoruz
        {
            //Başvuran biligilerini değerlendirme
            //
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
