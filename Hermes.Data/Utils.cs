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
            var IeSMRecords = IeSMDB.SubCategories.ToList();
            var HermesRecords = new List<Hermes.Domain.CallPriority>();

            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.SubCategoryId;
                var _description = _record.Description;
                var _dateModified = _record.DateModified;

                var _hermesCallPriority = new Hermes.Domain.CallPriority(_id, _description, _dateModified);
                HermesRecords.Add(_hermesCallPriority);
            }

            HermesDb.CallPriorities.UpdateRange(HermesRecords);
        }

        public void UpdateUserTable()
        {
            var IeSMRecords = IeSMDB.Users.ToList();
            var HermesRecords = new List<Hermes.Domain.User>();

            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.UserId;
                var _userName = _record.UserName;
                var _userEmail = _record.UserEmail;
                var _dateModified = _record.DateModified;

                var _hermesUser = new Hermes.Domain.User(_id, _userName, _userEmail, _dateModified);
                HermesRecords.Add(_hermesUser);
            }

            HermesDb.Users.AddRange(HermesRecords);
        }


        public void UpdateP1ToP0()
        {
            var _CallPriority = HermesDb.CallPriorities.Where(p => p.Id == 1).Single();
            var _Description = _CallPriority.Description;
            Console.WriteLine(_Description);
            _Description = "P1 - Critical ";
            HermesDb.CallPriorities.Update(_CallPriority);
            HermesDb.SaveChanges();

            HermesDbSaveChanges();

        }

        public int HermesDbSaveChanges()
        {
            Console.WriteLine("Saving DB");

            try
            {
                Task<int> updateDB = Task.Run(() => HermesDb.SaveChangesAsync());
                updateDB.Wait();
                Console.WriteLine(updateDB.Result.ToString() + " Updated Saving DB");
                return updateDB.Result;
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
            return 0;
        }

    
    }
}
