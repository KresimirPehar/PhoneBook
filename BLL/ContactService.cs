using AutoMapper;
using BLL.Interfaces;
using BLL.viewModels;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace BLL
{
    class ContactService : IService<Contact>
    {
        public Contact Add(Contact contact)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                vow.ContactRepository.Add(contact);
                vow.Complete();
                return contact;
            }
        }



        public IEnumerable<Contact> GetAll()
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                return vow.ContactRepository.GetAll().ToList();
            }
        }

        public Contact GetById(object id)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                Contact contact = vow.ContactRepository.GetById(id);
                return contact;
            }
        }

        public void Update(Contact contact)
        {
            using (UnitOfWork vow = new UnitOfWork())
            {
                Contact _contact = vow.ContactRepository.GetById(contact.ContactID);
                _contact.Address = contact.Address;
                _contact.TipBroja = contact.TipBroja;
                vow.Complete();
            }
        }
    }
    //public class ContactService : IService<ContactViewModel>
    //{
    //    public IEnumerable<ContactViewModel> GetAll()
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            return uow.ContactRepository.GetAll().ToList().Select(Mapper.Map<Contact, ContactViewModel>);
    //        }
    //    }
    //    public ContactViewModel GetById(object id)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            Contact contact = uow.ContactRepository.GetById(id);
    //            if (contact == null) throw new ArgumentNullException(nameof(contact));
    //            return Mapper.Map<Contact, ContactViewModel>(contact);
    //        }
    //    }
    //    public ContactViewModel Add(ContactViewModel contactViewModel)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            var contact = Mapper.Map<ContactViewModel, Contact>(contactViewModel);
    //            if (contact == null) throw new ArgumentNullException(nameof(contact));

    //            uow.ContactRepository.Add(contact);
    //            uow.Complete();

    //            contact.ContactID = contact.ContactID;
    //            return contactViewModel;
    //        }
    //    }
    //    public void Update(ContactViewModel contactViewModel)
    //    {
    //        using (UnitOfWork uow = new UnitOfWork())
    //        {
    //            Contact contact = uow.ContactRepository.GetById(contactViewModel.ContactID);
    //            if (contact == null) throw new ArgumentNullException(nameof(contact));
    //            Mapper.Map(contactViewModel, contact);
    //            uow.Complete();
    //        }
    //    }

    //    public void Delete(ContactViewModel entity)
    //    {
    //        throw new NotImplementedException();
    //    }

    //public void Delete(ContactViewModel entity)
    //{
    //    throw new NotImplementedException();
    //}
}


class ContactService : IService<Contact>
{
    public Contact Add(Contact contact)
    {
        using (UnitOfWork vow = new UnitOfWork())
        {
            vow.ContactRepository.Add(contact);
            vow.Complete();
            return contact;
        }
    }



    public IEnumerable<Contact> GetAll()
    {
        using (UnitOfWork vow = new UnitOfWork())
        {
            return vow.ContactRepository.GetAll().ToList();
        }
    }

    public Contact GetById(object id)
    {
        using (UnitOfWork vow = new UnitOfWork())
        {
            Contact contact = vow.ContactRepository.GetById(id);
            return contact;
        }
    }

    public void Update(Contact contact)
    {
        using (UnitOfWork vow = new UnitOfWork())
        {
            Contact _contact = vow.ContactRepository.GetById(contact.ContactID);
            _contact.Address = contact.Address;
            _contact.TipBroja = contact.TipBroja;
            vow.Complete();
        }
    }
}

