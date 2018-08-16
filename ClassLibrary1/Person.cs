using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonskiImenik.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual ICollection<Contact> ContactList { get; set; }
    }
}
