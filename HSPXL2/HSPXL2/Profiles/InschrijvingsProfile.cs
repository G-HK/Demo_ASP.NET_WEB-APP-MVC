using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Profiles
{
    public class InschrijvingsProfile : Profile
    {
        public InschrijvingsProfile()
        {
            CreateMap<Entities.Inschrijving, Models.InschrijvingDto>();

            CreateMap<Models.InschrijvingDto,Entities.Inschrijving>();

            CreateMap<Models.InschrijvingDto, Entities.Inschrijving>().ReverseMap();
        }
    }
}
