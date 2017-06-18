using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class IeSMCustomer
    {
        public IeSMCustomer()
        {
            Contacts = new HashSet<IeSMContacts>();
            LoggedCalls = new HashSet<LoggedCalls>();
            Users = new HashSet<IeSMUsers>();
        }

        public decimal CustNo { get; set; }
        public string CustName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public decimal? GroupNo { get; set; }
        public decimal? StatusNo { get; set; }
        public string Website { get; set; }
        public string Notes { get; set; }
        public string CustRef { get; set; }
        public short? OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }
        public short ContractWarningOption { get; set; }
        public decimal? AccountManager { get; set; }
        public decimal? DefaultPriority { get; set; }

        public virtual ICollection<IeSMContacts> Contacts { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCalls { get; set; }
        public virtual ICollection<IeSMUsers> Users { get; set; }
        public virtual IeSMUsers AccountManagerNavigation { get; set; }
        public virtual IeSMCallPriority DefaultPriorityNavigation { get; set; }
        public virtual CustomerGroups GroupNoNavigation { get; set; }
        public virtual CustomerStatus StatusNoNavigation { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
