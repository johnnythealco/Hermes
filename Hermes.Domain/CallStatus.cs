using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class CallStatus
    {
        public CallStatus()
        {

        }

        public CallStatus(int _id, string _description, DateTime _dateModified)
        {
            Id = _id;
            Description = _description;
            DateModified = _dateModified;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateModified { get; set; }
    }
}
