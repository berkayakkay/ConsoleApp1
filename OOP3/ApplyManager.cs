using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplyManager
    {
        public void Apply(ICreditBaseManager creditBaseManager)
        {
            //Başvuran bilgilerini değerlendir.
            //
            creditBaseManager.Calculate();



        }

    }
}
