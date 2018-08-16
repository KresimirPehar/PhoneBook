using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace DAL
{
    public class ContactRepository : GenericRepository<Contact>
    {
        public ContactRepository(DbContext context) : base(context)
        {

        }
    }
}
