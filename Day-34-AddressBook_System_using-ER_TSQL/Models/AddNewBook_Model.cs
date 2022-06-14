using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_34_AddressBook_System_using_ER_TSQL.Models
{
    internal class AddNewBook_Model
    {
        public int  BookId { get; set; }
        public string  BookName { get; set; }
        public string BookType { get; set; }
        public DateTime DateofBookCreation { get; set; }

    }
}
