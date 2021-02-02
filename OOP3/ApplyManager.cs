using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{//method injection
    class ApplyManager
    {
        public void Apply(ICreditBaseManager creditBaseManager,ILoggerService loggerService )
        {
            //Başvuran bilgilerini değerlendir.
            //
            creditBaseManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
