using AutoMapper;
using Pet.Core.Domain.Identity;
using Pet.Core.Enums.Domain.Identity;
using Pet.Core.Helper.Enums;
using Pet.Core.Models.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pet.Core.AutoMapper.Identity
{
    public class UserProfile : Profile, IProfile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserPageModel>()
                 .ForMember(p => p.UserTypeDesc, p => p.MapFrom(c => EnumHelper.GetDescription(c.UserType)))
                 .ForMember(p => p.ActivedDesc, p => p.MapFrom(c => c.Actived ? EnumHelper.GetDescription(AppUserActivedStatus.Actived) : EnumHelper.GetDescription(AppUserActivedStatus.NotActive)))
                 .ForMember(p => p.DeletedDesc, p => p.MapFrom(c => c.Deleted ? EnumHelper.GetDescription(AppUserDeletedStatus.Deleted) : EnumHelper.GetDescription(AppUserDeletedStatus.NotDeleted)));
            CreateMap<AppUser, UserDto>()
                .ForMember(p => p.UserTypeDesc, p => p.MapFrom(c => EnumHelper.GetDescription(c.UserType)));
            CreateMap<UserDto, AppUser>();
        }
    }
}
