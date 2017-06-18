using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hermes.Domain
{
    public class CallCategory
    {
        public CallCategory()
        {

        }

        public CallCategory(int _id, string _description, DateTime _dateModified)
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
