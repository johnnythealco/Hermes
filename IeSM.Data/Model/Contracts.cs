using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class Contracts
    {
        public decimal ContractNo { get; set; }
        public string Description { get; set; }
        public decimal? ContractType { get; set; }
        public string Notes { get; set; }
        public decimal? ContractSalePrice { get; set; }
        public decimal? ContractCost { get; set; }
        public short RepeatType { get; set; }
        public short RepeatValue { get; set; }
        public short? RepeatDay { get; set; }
        public short? RepeatDaynumber { get; set; }
        public short? RepeatMonth { get; set; }
        public short? RepeatAnnualMonth { get; set; }
        public short? RepeatPeriod { get; set; }
        public short OutOfUse { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateModified { get; set; }
        public decimal UserModified { get; set; }
        public short? ContractAllowance { get; set; }
        public string AllowanceType { get; set; }
        public decimal? AllowanceValue { get; set; }
        public decimal? DefaultPriority { get; set; }

        public virtual ContractTypes ContractTypeNavigation { get; set; }
        public virtual CallPriority DefaultPriorityNavigation { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
