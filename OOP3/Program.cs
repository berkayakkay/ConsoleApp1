using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager requirementManager = new RequirementManager();

            ICreditBaseManager vehicleCreditManager = new VehicleCreditManager();

            ICreditBaseManager housingCreditManager = new HousingCreditManager();

            ApplyManager applymanager = new ApplyManager();
            applymanager.Apply(vehicleCreditManager);
            

        }
    }
}
