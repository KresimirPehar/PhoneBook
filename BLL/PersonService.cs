using AutoMapper;
using BLL.Interfaces;
using BLL.viewModels;
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
    public class PersonService : IService<Person>
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
                _person.FirstName = person.FirstName;
                _person.RegistrationDate = person.RegistrationDate;
                vow.Complete();
            }
        }
    }
    //public class PersonService : IService<PersonViewModel>
    //{
    //    public IEnumerable<PersonViewModel> GetAll()
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            return uow.PersonRepository.GetAll().ToList().Select(Mapper.Map<Person, PersonViewModel>);
    //        }
    //    }
    //    public PersonViewModel GetById(object id)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            Person person = uow.PersonRepository.GetById(id);
    //            if (person == null) throw new ArgumentNullException(nameof(person));
    //            return Mapper.Map<Person, PersonViewModel>(person);
    //        }
    //    }
    //    public PersonViewModel Add(PersonViewModel personViewModel)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            var person = Mapper.Map<PersonViewModel, Person>(personViewModel);
    //            if (person == null) throw new ArgumentNullException(nameof(person));

    //            uow.PersonRepository.Add(person);
    //            uow.Complete();

    //            personViewModel.ID = person.ID;
    //            return personViewModel;
    //        }
    //    }
    //    public void Update(PersonViewModel personViewModel)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            Person person = uow.PersonRepository.GetById(personViewModel.ID);
    //            if (person == null) throw new ArgumentNullException(nameof(person));
    //            Mapper.Map(personViewModel, person);
    //            uow.Complete();
    //        }
    //    }
}
public class PersonService : IService<Person>
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
            _person.FirstName = person.FirstName;
            _person.RegistrationDate = person.RegistrationDate;
            vow.Complete();
        }
    }
}


