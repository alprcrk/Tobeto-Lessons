using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfacelerde o interfaci implement eden clasın referans numarasını tutabilir.

            ICreditManager personalLoanManager = new PersonalLoanManager(); //İhtiyaç kredi
            ICreditManager vehicleLoanManager = new VehicleLoanManager(); // Taşıt Kredi
            ICreditManager housingLoanManager = new HousingLoanManager(); // Konut Kredi

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(housingLoanManager, databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {personalLoanManager, vehicleLoanManager};

            //applicationManager.KrediOnBilgilendirmesiYap(credits);

            Console.ReadKey();
        }
    }
}
