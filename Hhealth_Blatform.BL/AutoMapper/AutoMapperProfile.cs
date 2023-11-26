using AutoMapper;
using Hhealth_Blatform.BL.Dtos;
using Hhealth_Blatform.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hhealth_Blatform.BL.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Therapist,ReadTherapistDto>().ReverseMap();
            CreateMap<Session,ReadSessionDto>().ReverseMap();
        }
    }
}
