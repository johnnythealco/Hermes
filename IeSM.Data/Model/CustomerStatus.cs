using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class CustomerStatus
    {
        public CustomerStatus()
        {
            Customers = new HashSet<IeSMCustomer>();
        }

        public decimal StatusNo { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public short? OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<IeSMCustomer> Customers { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
