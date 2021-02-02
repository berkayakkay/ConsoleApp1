using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager requirementManager = new RequirementManager();

            ICreditBaseManager vehicleCreditManager = new VehicleCreditManager();

            ICreditBaseManager housingCreditManager = new HousingCreditManager();

            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
           
            ILoggerService fileBaseLoggerService = new FilebaseLoggerService();
           
            ApplyManager applyManager = new ApplyManager();
            
            applyManager.Apply(vehicleCreditManager,fileBaseLoggerService);

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() {requirementManager, vehicleCreditManager };
            

        }
        

        }

        
    }
