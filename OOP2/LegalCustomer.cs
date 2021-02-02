using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//tüzel müsteriler için : coorporate
    //Inheritance-miras
    class LegalCustomer:Customer
    {
      
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
