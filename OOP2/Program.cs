using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "12345";
            customer1.CustomerId = 1;
            customer1.Name = "Berkay";
            customer1.Surname = "Akkaya";
            customer1.TcNumber = "1556256525";

            LegalCustomer customer2 = new LegalCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "54231";
            customer2.CompanyName = "Apple";
            customer2.TaxNumber = "1456628";

            Customer customer3 = new IndividualCustomer();
            Customer customer4= new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



            



        }
    }
}
