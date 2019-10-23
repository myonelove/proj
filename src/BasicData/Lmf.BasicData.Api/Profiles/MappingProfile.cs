using AutoMapper;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Model.Request; 
using Lmf.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lmf.BasicData.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddStaffModel, Staff>();
            CreateMap<ModifyStaffModel, Staff>();
            CreateMap<Staff,StaffModel>();
        }
    }
}
