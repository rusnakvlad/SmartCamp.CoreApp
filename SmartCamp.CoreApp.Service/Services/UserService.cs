using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmartCamp.Core.Domain.Entities;
using SmartCamp.CoreApp.Service.DTOs;
using SmartCamp.CoreApp.Service.Interfaces;

namespace SmartCamp.CoreApp.Service.Services;

public class UserService : IUserService
{
    private readonly UserManager<User> _userManager;

    public UserService(UserManager<User> userManager)
    {
        _userManager = userManager;
    }


    public async Task CreateUser(CreateUserDto userDto)
    {
        var user = new User()
        {
            FirstName = userDto.FirstName,
            LastName = userDto.LastName,
            UserName = userDto.Username,
            Email = userDto.Email
        };

        var createdUser = await _userManager.CreateAsync(user, userDto.Password);

        if (createdUser.Succeeded)
        {
            var roleResult = await _userManager.AddToRoleAsync(user, "Admin");
            if (!roleResult.Succeeded)
            {
                throw new Exception($"User with email: {user.Email} was not bind to role Admin");
            }
        }
    }

    public async Task<IEnumerable<UserDto>> GetAllUsers()
    {
        var users = await _userManager.Users.AsNoTracking()
            .ToListAsync();

        return users.Select(x => new UserDto()
        {
            Id = x.Id,
            FirstName = x.FirstName,
            LastName = x.LastName,
            Email = x.Email,
            Username = x.UserName
        });
    }
}