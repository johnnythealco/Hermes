﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Domain
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public string FaxNo { get; set; }
        public DateTime DateModified { get; set; }
        public Customer Customer { get; set; }

        public Contact()
        {
                
        }

        public Contact(int id, string contactName, string email, string phoneNo, string mobileNo, string faxNo, DateTime dateModified, Customer customer)
        {
            Id = id;
            ContactName = contactName;
            Email = email;
            PhoneNo = phoneNo;
            MobileNo = mobileNo;
            FaxNo = faxNo;
            DateModified = dateModified;
            Customer = customer;
        }
    }
}
