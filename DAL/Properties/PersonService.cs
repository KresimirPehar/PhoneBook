using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace BLL
{
    public class PersonService :  
    {
        public Person Add(Person person)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                vow.PersonRepository.Add(person);
                vow.Complete();
                return person;
            }
        }

        public IEnumerable<Person> GetAll()
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                return vow.PersonRepository.GetAll().ToList();
            }
        }

        public Person GetById(object id)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                Person person = vow.PersonRepository.GetById(id);
                return person;
            }
        }

        public void Update(Person person)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                Person _person = vow.PersonRepository.GetById(person.ID);
                _person.LastName = person.LastName;
                vow.Complete();
            }
        }
    }
}
