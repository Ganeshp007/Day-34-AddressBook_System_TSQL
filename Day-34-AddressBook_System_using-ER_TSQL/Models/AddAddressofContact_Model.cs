using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_34_AddressBook_System_using_ER_TSQL.Models
{
    internal class AddAddressofContact_Model
    {
        public int PersonId { get; set; } 
        public int AddressId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
    }
}
