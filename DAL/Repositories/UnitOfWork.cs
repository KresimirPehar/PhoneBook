using DAL.Interfaces;
using System.Data.Entity;
using TelefonskiImenik.Model;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        internal readonly DbContext Context;
        public IRepository<Person> PersonRepository { get; }
        public IRepository<Contact> ContactRepository { get; }

        //private TelefonskiImenikDbContext context;
        //private AddressBookContext context;
        public UnitOfWork()
        {
            Context = new TelefonskiImenikDbContext();
            PersonRepository = new PersonRepository(Context);
            ContactRepository = new ContactRepository(Context);
        }

        public void Complete()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
