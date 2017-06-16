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
            //Utils.UpdateCallPriorityTable();
            Utils.UpdateP1ToP0();


            //Task<bool> updateDB = Task.Run(() => Utils.HermesDbSaveChangesAsync());

            ////updateDB.Wait();
            //bool sucess = updateDB.Result;
            //Console.WriteLine("done");

        }


        //static async Task HermesDbSaveChangesAsync()
        //{
        //    Console.WriteLine("Running");


        //    var Utils = new Utils();
        //    Utils.UpdateCallPriorityTable();
        //    bool x = await Utils.HermesDbSaveChangesAsync();
        //}

        //// Simple async function returning a string...
        //static public async Task<string> CallHttp()
        //{
        //    // Just a demo.  Normally my HttpClient is global (see docs)
        //    HttpClient aClient = new HttpClient();
        //    // async function call we want to wait on, so wait
        //    string astr = await aClient.GetStringAsync("http://microsoft.com");
        //    // return the value
        //    return astr;
        //}
    }
}
