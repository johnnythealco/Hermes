using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime DateModified { get; set; }

        public User()
        {

        }

        public User(int _Id,string _userName,string _userEmail, DateTime _dateModified)
        {
            Id = _Id;
            UserName = _userName;
            UserEmail = _userEmail;
        }


    }
}
