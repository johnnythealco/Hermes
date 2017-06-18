using Hermes.Domain;
using IeSM.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hermes.Data
{
    public class Utils
    {
        private IeSMContext IeSMDB = new IeSMContext();
        private HermesDbContext HermesDb = new HermesDbContext();


        public void UpdateCallPriorityTable()
        {
            var IeSMRecords = IeSMDB.SubCategories.ToList();

            Console.WriteLine("Checking CallPriority Table");
            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.SubCategoryId;
                var _description = _record.Description;
                var _dateModified = _record.DateModified;
                var _hermesCallPriority = HermesDb.CallPriorities.Find(_id);

                if (_hermesCallPriority != null)
                {
                    if (_hermesCallPriority.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record : " + _description);
                        _hermesCallPriority.Description = _description;
                        _hermesCallPriority.DateModified = _dateModified;
                        HermesDb.CallPriorities.Update(_hermesCallPriority);
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : "+ _description);
                    var _newHermesCallPriority = new CallPriority(_id, _description, _dateModified);
                    HermesDb.CallPriorities.Add(_newHermesCallPriority);
                }
            }
            Console.WriteLine("Finished Checking CallPriority Table");

        }

        public void UpdateCallCategoryTable()
        {
            var IeSMRecords = IeSMDB.CallCategories.ToList();

            Console.WriteLine("Checking CallCategory Table");

            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.CallCategory;
                var _description = _record.Description;
                var _dateModified = _record.DateModified;
                var _hermesCallCategory = HermesDb.CallCategories.Find(_id);

                if (_hermesCallCategory != null)
                {
                    if (_hermesCallCategory.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record : " + _description);
                        _hermesCallCategory.Description = _description;
                        _hermesCallCategory.DateModified = _dateModified;
                        HermesDb.CallCategories.Update(_hermesCallCategory);
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : " + _description);
                    var _newHermesCallCategory = new CallCategory(_id, _description, _dateModified);
                    HermesDb.CallCategories.Add(_newHermesCallCategory);
                }
            }
            Console.WriteLine("Finished Checking CallCategory Table");

        }

        public void UpdateUserTable()
        {
            var IeSMRecords = IeSMDB.Users.ToList();
            var HermesRecords = new List<User>();
            Console.WriteLine("Checking UserTable");

            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.UserId;
                var _userName = _record.UserName;
                var _userEmail = _record.UserEmail;
                var _dateModified = _record.DateModified;
                var _hermesUser = HermesDb.Users.Find(_id);

                if(_hermesUser != null)
                {
                    //Console.WriteLine("Checking User : " + _userName);
                    if (_hermesUser.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating User : " + _userName);
                        _hermesUser.UserName = _userName;
                        _hermesUser.UserEmail = _userEmail;
                        _hermesUser.DateModified = _dateModified;
                        HermesDb.Users.Update(_hermesUser);
                    }
                }
                else
                {
                    var _newHermesUser = new User(_id, _userName, _userEmail, _dateModified);
                    Console.WriteLine("Adding User : " + _newHermesUser.UserName);
                    HermesDb.Users.Add(_newHermesUser);
                }

            }
            Console.WriteLine("Finished Checking UserTable");

        }

        public void UpdateCallStatusTable()
        {
            var IeSMRecords = IeSMDB.CallStatus.ToList();
            var HermesRecords = new List<CallStatus>();
            Console.WriteLine("Checking CallStatus Table");
            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.StatusNo;
                var _description = _record.Description;
                var _dateModified = _record.DateModified;
                var _hermesCallStatus = HermesDb.CallStatus.Find(_id);

                if (_hermesCallStatus != null)
                {
                    if (_hermesCallStatus.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record : " + _description);
                        _hermesCallStatus.Description = _description;
                        _hermesCallStatus.DateModified = _dateModified;
                        HermesDb.CallStatus.Update(_hermesCallStatus);
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : " + _description);
                    var _newHermesCallStatus = new CallStatus(_id, _description, _dateModified);
                    HermesDb.CallStatus.Add(_newHermesCallStatus);
                }
            }
            Console.WriteLine("Finished Checking CallStatus Table");
        }

        public void UpdateCustomerTable()
        {
            var IeSMRecords = IeSMDB.Customers.ToList();
            var HermesRecords = new List<Customer>();

            Console.WriteLine("Checking Customer Table");
            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.CustNo;
                var _customerName = _record.CustName;
                var _Address1 = _record.Address1;
                var _Address2 = _record.Address2;
                var _Address3 = _record.Address3;
                var _Address4 = _record.Address4;
                var _Address5 = _record.Address5;
                var _PhoneNo = _record.PhoneNo;
                var _FaxNo = _record.FaxNo;
                var _dateModified = _record.DateModified;

                var _hermesCustomer = HermesDb.Customers.Find(_id);

                if (_hermesCustomer != null)
                {
                    if (_hermesCustomer.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record : " + _customerName);
                        _hermesCustomer.Name = _customerName;
                        _hermesCustomer.DateModified = _dateModified;
                        _hermesCustomer.Address1 = _Address1;
                        _hermesCustomer.Address2 = _Address2;
                        _hermesCustomer.Address3 = _Address3;
                        _hermesCustomer.Address4 = _Address4;
                        _hermesCustomer.Address5 = _Address5;
                        _hermesCustomer.PhoneNo = _PhoneNo;
                        _hermesCustomer.FaxNo = _FaxNo;

                        HermesDb.Customers.Update(_hermesCustomer);
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : " + _customerName);
                    var _newHermesCustomer = new Customer(_id, _customerName, _Address1, _Address2, _Address3, _Address4, _Address5,_PhoneNo,_FaxNo, _dateModified);
                    HermesDb.Customers.Add(_newHermesCustomer);
                }
            }
            Console.WriteLine("Finished Checking Customer Table");

        }

        public void UpdateContactTable()
        {
            var IeSMRecords = IeSMDB.Contacts.ToList();
            var HermesRecords = new List<Contact>();

            Console.WriteLine("Checking Contact Table");
            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.ContactId;
                var _ContactName = _record.ContactName;
                var _Email = _record.Email;
                var _MobileNo = _record.MobileNo;           
                var _PhoneNo = _record.PhoneNo;
                var _FaxNo = _record.FaxNo;
                var _dateModified = _record.DateModified;

                var _Customer = HermesDb.Customers.Find((int)_record.CustNo);

                var _hermesContact = HermesDb.Contacts.Find(_id);

                if (_hermesContact != null && _Customer != null)
                {
                    if (_hermesContact.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record : " + _ContactName);
                        _hermesContact.ContactName = _ContactName;
                        _hermesContact.DateModified = _dateModified;
                        _hermesContact.Email = _Email;
                        _hermesContact.MobileNo = _MobileNo;
                        _hermesContact.PhoneNo = _PhoneNo;
                        _hermesContact.FaxNo = _FaxNo;
                        _hermesContact.Customer = _Customer;

                        HermesDb.Contacts.Update(_hermesContact);
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : " + _ContactName);
                    var _newHermesContact = new Contact(_id, _ContactName, _Email, _PhoneNo, _MobileNo, _FaxNo, _dateModified, _Customer);
                    HermesDb.Contacts.Add(_newHermesContact);
                }
            }
            Console.WriteLine("Finished Checking Contact Table");

        }


        public void UpdateCallTable()
        {
            var IeSMRecords = IeSMDB.LoggedCalls.Where(call => call.CallClosed == 0 && call.AssignedTo != null && call.SubCategoryId != null).ToList();
            var HermesRecords = new List<Call>();

            Console.WriteLine("Checking Call Table");
            foreach (var _record in IeSMRecords)
            {
                var _id = (int)_record.CallNo;
                var _LoggedBy = HermesDb.Users.Find((int)_record.LoggedBy);
                //var _ClosedBy = HermesDb.Users.Find((int)_record.ClosedBy);

                User _AssignedTo = HermesDb.Users.Find((int)_record.AssignedTo);
                var _DateLogged = _record.DateLogged;
                //var _DateClosed = (DateTime)_record.DateClosed;

                int _CallDuration;
                if (_record.CallDuration != null)
                {
                   _CallDuration = (int)_record.CallDuration;
                }else
                {
                    _CallDuration = 0;
                }

                int _TotalDuration;
                if (_record.TotalDuration != null)
                {
                    _TotalDuration = (int)_record.CallDuration;
                }
                else
                {
                    _TotalDuration = 0;
                }

                Customer _Customer = HermesDb.Customers.Find((int)_record.CustNo);
                var _Contact = _record.ContactName;
                var _CallDescription = _record.CallDescription;
                var _Problem = _record.Problem;
                var _Solution = _record.Solution;
                var _CallClosed = (int)_record.CallClosed;
                CallPriority _Priority = HermesDb.CallPriorities.Find((int)_record.SubCategoryId);
                CallCategory _CallCategory = HermesDb.CallCategories.Find((int)_record.CallCategory);
                CallStatus _Status = HermesDb.CallStatus.Find((int)_record.StatusNo);
                var _DateModified = (DateTime)_record.DateModified;
                User _UserModified = HermesDb.Users.Find((int)_record.UserModified);
                var _Resolved = (int)_record.PriorityNo;




                var _hermesCall = HermesDb.Calls.Find(_id);

                if (_hermesCall != null)
                {
                    if (_hermesCall.DateModified.CompareTo(_record.DateModified) != 0) // Returns -1 if the ieSM record is newer
                    {
                        Console.WriteLine("Updating Record Call No: " + _id);

                        _hermesCall.LoggedBy = _LoggedBy;
                        //_hermesCall.ClosedBy = _ClosedBy;
                        _hermesCall.AssignedTo = _AssignedTo;
                        _hermesCall.DateLogged = _DateLogged;
                        //_hermesCall.DateClosed = _DateClosed;
                        _hermesCall.CallDuration= _CallDuration;
                        _hermesCall.TotalDuration = _TotalDuration;
                        _hermesCall.Customer = _Customer;
                        _hermesCall.Contact = _Contact;
                        _hermesCall.CallDescription = _CallDescription;
                        _hermesCall.Problem = _Problem;
                        _hermesCall.Solution = _Solution;
                        _hermesCall.CallClosed = _CallClosed;
                        _hermesCall.Priority = _Priority;
                        _hermesCall.CallCategory = _CallCategory;
                        _hermesCall.Status = _Status;
                        _hermesCall.DateModified = _DateModified;
                        _hermesCall.UserModified = _UserModified;
                        _hermesCall.Resolved = _Resolved;
                    }
                }
                else
                {
                    Console.WriteLine("Adding Record : " + _id);

                    var _newHermesCall = new Call(_id, _LoggedBy, /*_ClosedBy,*/ _AssignedTo, _DateLogged, /*_DateClosed,*/_CallDuration,_TotalDuration,_Customer,_Contact,
                        _CallDescription,_Problem,_Solution,_CallClosed,_Priority,_CallCategory, _Status,_DateModified,_UserModified,_Resolved);

                    HermesDb.Calls.Add(_newHermesCall);
                }
            }
            Console.WriteLine("Finished Checking Call Table");

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
