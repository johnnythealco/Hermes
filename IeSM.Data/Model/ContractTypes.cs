using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class ContractTypes
    {
        public ContractTypes()
        {
            Contracts = new HashSet<Contracts>();
        }

        public decimal ContractType { get; set; }
        public string Description { get; set; }
        public short OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<Contracts> Contracts { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
