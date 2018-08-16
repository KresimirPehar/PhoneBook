using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        public GenericRepository(DbContext context)
        {
            this.Context = context;
            this.DbSet = context.Set<T>();
        }

        internal DbContext Context;
        internal DbSet<T> DbSet;

        public virtual void Add(T entity)
        {
            try
            {
                DbSet.Add(entity);
            }
            catch (Exception ex)
            {

            }
        }

        public virtual void Delete(T entityToDelete)
        {
            DbSet.Remove(entityToDelete);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T GetById(object id)
        {
            return DbSet.Find(id);
        }
    }

}
