using DAL.Repository;
using System.Data.Entity;
using TelefonskiImenik.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PersonRepository : GenericRepository<Person>
    {

        public PersonRepository(DbContext context) : base(context)
        {

        }
    }
}
