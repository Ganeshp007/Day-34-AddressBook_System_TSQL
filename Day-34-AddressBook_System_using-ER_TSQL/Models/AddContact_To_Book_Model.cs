using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_34_AddressBook_System_using_ER_TSQL.Models
{
    internal class AddContact_To_Book_Model
    {
        public int BookId { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public char Gender { get; set; }
        public long MobileNo { get; set; }
        public int AddressId { get; set; }
    }
}
