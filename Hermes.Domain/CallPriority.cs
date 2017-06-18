using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hermes.Domain
{
    public class CallPriority
    {
        public CallPriority()
        {

        }
   
        public CallPriority(int _IeSM_SUB_CATEGORY_ID, String _description, DateTime _dateModified)
        {
            Id = _IeSM_SUB_CATEGORY_ID;
            Description = _description;
            DateModified = _dateModified;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        //public int IeSM_SUB_CATEGORY_ID { get; set; }
        public string Description { get; set; }
        public DateTime DateModified { get; set; }


        public void Update(String _description, DateTime _dateModified)
        {
            Description = _description;
            DateModified = _dateModified;
        }
    }
}
