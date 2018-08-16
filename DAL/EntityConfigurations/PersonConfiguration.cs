using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace DAL.EntityConfiguration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("Peoplee");

            HasKey(r => r.ID);

            Property(r => r.FirstName).IsRequired().HasMaxLength(50);

            Property(r => r.LastName).IsRequired().HasMaxLength(20);
        }
    }
}
