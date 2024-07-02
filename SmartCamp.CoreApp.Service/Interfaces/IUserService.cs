using SmartCamp.Core.Domain.DTOs.User;

namespace SmartCamp.CoreApp.Service.Interfaces;

public interface IUserService
{
    Task CreateUser(CreateUserDto userDto);
    Task<IEnumerable<UserDto>> GetAllUsers();
}