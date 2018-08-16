using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace DAL
{
    public class Initializer : DropCreateDatabaseIfModelChanges<TelefonskiImenikDbContext>
    {
        protected override void Seed(TelefonskiImenikDbContext context)
        {
            var person = new List<Person>
            {
                new Person {FirstName = "Krešimir", LastName = "Pehar", RegistrationDate = DateTime.Parse("1/2/1995")},
                new Person {FirstName = "Mate", LastName = "Matić", RegistrationDate = DateTime.Parse("6/1/1998")}
            };

            person.ForEach(p => context.People.Add(p));
            context.SaveChanges();

            var contact = new List<Contact>
            {
                new Contact {Address="Rudarska 138"},
                new Contact {Address="Rudarska 138"}
            };

            contact.ForEach(p => context.Contacts.Add(p));
            context.SaveChanges();
        }
    }
}
