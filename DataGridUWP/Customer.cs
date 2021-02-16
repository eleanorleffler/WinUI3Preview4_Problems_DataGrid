using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridUWP
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }

        public Customer(string firstName, string lastName, string address, string notes)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Notes = notes;
        }
    }
}
