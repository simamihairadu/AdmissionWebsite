using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<AdmissionEntry, AdmissionEntryViewModel>().ReverseMap();
            CreateMap<Contestant, ContestantViewModel>().ReverseMap();
            CreateMap<Department, DepartmentViewModel>().ReverseMap();
            CreateMap<Session, SessionViewModel>().ReverseMap();
            CreateMap<Specialization, SpecializationViewModel>().ReverseMap();
            CreateMap<Option, OptionViewModel>().ReverseMap();
            CreateMap<Option, EntryOptionViewModel>().ReverseMap();
        }
    }
}
