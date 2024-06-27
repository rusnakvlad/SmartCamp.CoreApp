using Microsoft.AspNetCore.Mvc;
using SmartCamp.CoreApp.Service.DTOs;
using SmartCamp.CoreApp.Service.Interfaces;

namespace SmartCamp.CoreApp.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }


    [HttpPost("create")]
    public async Task<IActionResult> CreateAsync([FromBody] CreateUserDto request)
    {
        await _userService.CreateUser(request);
        return Ok();
    }
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAllAsync()
    {
        var response = await _userService.GetAllUsers();
        return Ok(response);
    }
}