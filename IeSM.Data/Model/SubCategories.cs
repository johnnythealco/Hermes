using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class SubCategories
    {
        public SubCategories()
        {
            CategorySubCategories = new HashSet<CategorySubCategories>();
            LoggedCalls = new HashSet<LoggedCalls>();
        }

        public decimal SubCategoryId { get; set; }
        public string Description { get; set; }
        public short OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<CategorySubCategories> CategorySubCategories { get; set; }
        public virtual ICollection<LoggedCalls> LoggedCalls { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
