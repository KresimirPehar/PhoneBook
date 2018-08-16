using DAL.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

    namespace DAL
    {
        public class TelefonskiImenikDbContext : DbContext
        {
            public TelefonskiImenikDbContext() : base("TelefonskiImenikDbContext")
            {
            }

            public DbSet<Person> People { get; set; }
            public DbSet<Contact> Contacts { get; set; }


            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Configurations.Add(new PersonConfiguration());
                modelBuilder.Configurations.Add(new ContactConfiguration());
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TelefonskiImenikDbContext>());
                base.OnModelCreating(modelBuilder);
            }

        //public System.Data.Entity.DbSet<BLL.viewModels.PersonViewModel> PersonViewModels { get; set; }

        //public System.Data.Entity.DbSet<BLL.viewModels.PersonViewModel> PersonViewModels { get; set; }
    }
    }

