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
        public User LoggedBy { get; set; }
        public User ClosedBy { get; set; }
        public User AssignedTo { get; set; }

        public DateTime DateLogged { get; set; }
        public DateTime DateClosed { get; set; }
        public int CallDuration { get; set; }
        public int TotalDuration { get; set; }

        public Customer Customer { get; set; }
        public string Contact { get; set; }

        public string CallDescription { get; set; }
        public string Problem { get; set; }
        public string Solution { get; set; }

        public int CallClosed { get; set; }

        public CallPriority Priority { get; set; }
        public CallCategory CallCategory { get; set; }
        public CallStatus Status { get; set; }


        public DateTime DateModified { get; set; }
        public User UserModified { get; set; }

        public int Resolved { get; set; }

        #region Construstors

        public Call()
        {
                
        }

        public Call(int id, User loggedBy,
            /*User closedBy,*/ User assignedTo,
            DateTime dateLogged, /*DateTime dateClosed,*/
            int callDuration, int totalDuration,
            Customer customer, string contact,
            string callDescription, string problem,
            string solution, int callClosed,
            CallPriority priority, CallCategory callCategory,
            CallStatus status, DateTime dateModified,
            User userModified, int resolved)
        {
            Id = id;
            LoggedBy = loggedBy;
            //ClosedBy = closedBy;
            AssignedTo = assignedTo;
            DateLogged = dateLogged;
            //DateClosed = dateClosed;
            CallDuration = callDuration;
            TotalDuration = totalDuration;
            Customer = customer;
            Contact = contact;
            CallDescription = callDescription;
            Problem = problem;
            Solution = solution;
            CallClosed = callClosed;
            Priority = priority;
            CallCategory = callCategory;
            Status = status;
            DateModified = dateModified;
            UserModified = userModified;
            Resolved = resolved;
        }

        #endregion

    }
}
