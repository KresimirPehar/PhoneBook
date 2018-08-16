using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace DAL.EntityConfiguration
{
    public class ContactConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactConfiguration()
        {
            ToTable("Contactss");

            HasKey(r => r.ContactID);

            HasRequired<Person>(t => t.Person).WithMany(t => t.ContactList);

        }
    }
}
