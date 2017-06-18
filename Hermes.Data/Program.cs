using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var Utils = new Utils();
            Utils.UpdateCallStatusTable();
            Utils.UpdateCallCategoryTable();
            Utils.UpdateCallPriorityTable();
            Utils.UpdateUserTable();
            Utils.UpdateCustomerTable();

            Utils.HermesDbSaveChanges();

            Utils.UpdateContactTable();
            Utils.HermesDbSaveChanges();

            Utils.UpdateCallTable();
            Utils.HermesDbSaveChanges();

            Console.WriteLine("Done");
        }


    }
}
