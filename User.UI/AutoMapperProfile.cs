using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.App.ViewModel;
using User.Domain;
using User.Domain.Model;

namespace User.UI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TestUser, GetUserVM>();
        }
    }
}
