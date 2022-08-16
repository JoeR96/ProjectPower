using AutoMapper;
using ProjectPowerData.Folder.Models;
using ProjectPowerWebApi.Controllers.Areas.Login.TokenResources;

namespace ProjectPowerWebApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CreateUserAccountModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(x => x.Password, opt => opt.MapFrom(x => x.Password))
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName));
        }
    }
}
