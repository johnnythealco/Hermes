using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class IeSMContacts
    {
        public decimal CustNo { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string Email { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }
        public string MobileNo { get; set; }
        public short IncludeInMailMerge { get; set; }
        public short IncludeInMailShots { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Salutation { get; set; }
        public int ContactId { get; set; }
        public short? MainContact { get; set; }

        public virtual IeSMCustomer CustNoNavigation { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
