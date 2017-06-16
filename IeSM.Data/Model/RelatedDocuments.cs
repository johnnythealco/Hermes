using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class RelatedDocuments
    {
        public decimal SystemNo { get; set; }
        public string SystemType { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
