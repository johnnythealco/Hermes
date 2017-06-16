using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class Customer
    {
        public int Id { get; set; } //IeSM Cusytomer Number
        public int IeSM_SUB_CATEGORY_ID { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime DateModified { get; set; }


    }
}
