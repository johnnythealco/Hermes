using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class User
    {
        public int Id { get; set; }
        public int IeSM_USER_ID { get; set; }
        public string UserName { get; set; }        
        public string UserEmail { get; set; }
        public DateTime DateModified { get; set; }
    }
}
