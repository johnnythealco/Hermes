using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class Call
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int IeSM_CALL_NO { get; set; }
        public User LoggedBy { get; set; }
        public User ClosedBy { get; set; }
        public User AssignedTo { get; set; }

        public DateTime DateLogged { get; set; }
        public DateTime DateClosed { get; set; }
        public int CallDuration { get; set; }
        public int TotalDuration { get; set; }

        public Customer Customer { get; set; }
        public Contact Contact { get; set; }

        public string CallDescription { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }

        public bool CallClosed { get; set; }

        public CallPriority Priority { get; set; }
        public CallCategory CallCategory { get; set; }
        public CallStatus Status { get; set; }


        public DateTime DateModified { get; set; }
        public User UserModified { get; set; }

        public bool Resolved { get; set; }


    }
}
