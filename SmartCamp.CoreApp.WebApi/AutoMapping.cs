using AutoMapper;
using SmartCamp.Core.Domain.DTOs.User;
using SmartCamp.Core.Domain.Entities;

namespace SmartCamp.CoreApp.WebApi;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        #region User
        CreateMap<User, UserDto>().ReverseMap();
        #endregion
    }
}