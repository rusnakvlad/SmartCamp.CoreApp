using SmartCamp.CoreApp.Service.DTOs;

namespace SmartCamp.CoreApp.Service.Interfaces;

public interface IUserService
{
    Task CreateUser(CreateUserDto userDto);
    Task<IEnumerable<UserDto>> GetAllUsers();
}