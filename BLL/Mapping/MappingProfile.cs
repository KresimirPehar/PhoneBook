using AutoMapper;
using BLL.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonskiImenik.Model;

namespace BLL.Mapping
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonViewModel, Person>();
            CreateMap<Person, PersonViewModel>();
            CreateMap<ContactViewModel, Contact>();
            CreateMap<Contact, ContactViewModel>();

        }
    }
}
