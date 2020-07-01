using AutoMapper;
using ProContacts.Models;
using ProContacts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProContacts.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Contact, ContactViewModel>().ReverseMap();
            CreateMap<AgeCategory, ContactViewModel>().ReverseMap();
            CreateMap<Club, ContactViewModel>().ReverseMap();
            CreateMap<District, ContactViewModel>().ReverseMap();
            CreateMap<Role, ContactViewModel>().ReverseMap();
            CreateMap<Season, ContactViewModel>().ReverseMap();
            CreateMap<Sport, ContactViewModel>().ReverseMap();
            CreateMap<Team, ContactViewModel>().ReverseMap();

        }
    }
}
