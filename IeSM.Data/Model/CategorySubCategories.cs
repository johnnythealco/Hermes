using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class CategorySubCategories
    {
        public decimal CallCategory { get; set; }
        public decimal SubCategoryId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateModified { get; set; }
        public decimal UserModified { get; set; }

        public virtual CallCategories CallCategoryNavigation { get; set; }
        public virtual SubCategories SubCategory { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
