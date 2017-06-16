using IeSM.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Data
{
    public class Utils
    {
        IeSMContext IeSMDB = new IeSMContext();
        HermesDbContext HermesDb = new HermesDbContext();


        public void UpdateCallPriorityTable()
        {
            var IeSMCallPriorities = IeSMDB.SubCategories.ToList();
            var hermesCallPriorities = new List<Hermes.Domain.CallPriority>();


            foreach (var _callPriority in IeSMCallPriorities)
            {
                var _id = (int)_callPriority.SubCategoryId;
                var _description = _callPriority.Description;
                var _hermesCallPriority = new Hermes.Domain.CallPriority(_id, _description);

                hermesCallPriorities.Add(_hermesCallPriority);

            }

            var p = hermesCallPriorities.ToList();


            HermesDb.AddRange(hermesCallPriorities);

            HermesDb.SaveChanges();

            var Q = HermesDb.CallPriorities.ToList();
        }

        public void UpdateP1ToP0()
        {
            var _CallPriority = HermesDb.CallPriorities.Where(p => p.Id == 1).Single();
            var _Description = _CallPriority.Description;
            Console.WriteLine(_Description);
            _Description = "P1 - Critical ";
            HermesDb.CallPriorities.Update(_CallPriority);
            HermesDb.SaveChanges();

            Task<bool> updateDB = Task.Run(() => HermesDbSaveChangesAsync());

            updateDB.Wait();
            bool sucess = updateDB.Result;
            Console.WriteLine("done");

        }

        public async Task<bool> HermesDbSaveChangesAsync()
        {
            //var p = HermesDb.CallPriorities.ToList();
            Console.WriteLine("Saving DB");

            try
            {
                var Rows = await HermesDb.SaveChangesAsync();
                Console.WriteLine(Rows + " Updated Saving DB");
            }
            catch(DbUpdateException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }  


            return true;
        }

    
    }
}
