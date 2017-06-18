using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class LoggedCalls
    {
        public decimal CallNo { get; set; }
        public decimal LoggedBy { get; set; }
        public DateTime DateLogged { get; set; }
        public decimal CustNo { get; set; }
        public decimal? ProductNo { get; set; }
        public string ContactName { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }
        public short? CallClosed { get; set; }
        public decimal? ClosedBy { get; set; }
        public DateTime? DateClosed { get; set; }
        public decimal? CallDuration { get; set; }
        public decimal? TotalDuration { get; set; }
        public decimal? CallType { get; set; }
        public decimal? AssignedTo { get; set; }
        public decimal? CallCategory { get; set; }
        public decimal? StatusNo { get; set; }
        public string CallDescription { get; set; }
        public short WebCall { get; set; }
        public short PublishToWeb { get; set; }
        public DateTime? DateModified { get; set; }
        public decimal? UserModified { get; set; }
        public DateTime? DueDate { get; set; }
        public short OutOfHours { get; set; }
        public decimal? SubCategoryId { get; set; }
        public string SerialNo { get; set; }
        public decimal? PriorityNo { get; set; }
        public double? ParentCall { get; set; }
        public decimal? ComponentId { get; set; }
        public decimal? CustomerContractNo { get; set; }
        public short? ViaLogger { get; set; }

        public virtual IeSMUsers AssignedToNavigation { get; set; }
        public virtual CallCategories CallCategoryNavigation { get; set; }
        public virtual CallTypes CallTypeNavigation { get; set; }
        public virtual IeSMUsers ClosedByNavigation { get; set; }
        public virtual IeSMCustomer CustNoNavigation { get; set; }
        public virtual IeSMUsers LoggedByNavigation { get; set; }
        public virtual IeSMCallPriority PriorityNoNavigation { get; set; }
        public virtual IeSMCallStatus StatusNoNavigation { get; set; }
        public virtual SubCategories SubCategory { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
