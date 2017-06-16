using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class CallPriority
    {
        public CallPriority()
        {
            Contracts = new HashSet<Contracts>();
            Customers = new HashSet<IeSMCustomer>();
            LoggedCalls = new HashSet<LoggedCalls>();
        }

        public decimal PriorityNo { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public decimal? PriorityColour { get; set; }
        public short OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }
        public int? DefaultMinutes { get; set; }

        public virtual ICollection<Contracts> Contracts { get; set; }
        public virtual ICollection<IeSMCustomer> Customers { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCalls { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
