using System;
using System.Collections.Generic;

namespace IeSM.Data.Model
{
    public partial class Profiles
    {
        public Profiles()
        {
            Users = new HashSet<IeSMUsers>();
        }

        public decimal ProfileNo { get; set; }
        public string Description { get; set; }
        public string AccessRights { get; set; }
        public decimal? Checksum { get; set; }
        public short ProfileType { get; set; }
        public short? OutOfUse { get; set; }
        public decimal UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal UserModified { get; set; }
        public DateTime DateModified { get; set; }

        public virtual ICollection<IeSMUsers> Users { get; set; }
        public virtual IeSMUsers UserCreatedNavigation { get; set; }
        public virtual IeSMUsers UserModifiedNavigation { get; set; }
    }
}
