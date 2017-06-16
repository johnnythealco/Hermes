using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class Contact
    {
        public int Id { get; set; }
        public int IeSM_CONTACT_ID { get; set; }
        public string ContactName { get; set; }

        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime DateModified { get; set; }
        public Customer Customer { get; set; }
        
    }
}
