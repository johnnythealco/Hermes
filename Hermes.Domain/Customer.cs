using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int id, string name, string address1, string address2, string address3, string address4, string address5, string phoneNo, string faxNo, DateTime dateModified)
        {
            Id = id;
            Name = name;
            Address1 = address1;
            Address2 = address2;
            Address3 = address3;
            Address4 = address4;
            Address5 = address5;
            PhoneNo = phoneNo;
            FaxNo = faxNo;
            DateModified = dateModified;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; } //IeSM Customer Number
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
