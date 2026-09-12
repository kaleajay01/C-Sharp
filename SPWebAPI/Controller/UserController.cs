using SPWebAPI.Entities;
using SPWebAPI.Repository.IRepositoryn;
using SPWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SPWebAPI.Controller;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IRepository _repository;
    public UserController(IRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllUser()
    {
        var users = _repository.GetAllUsers();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var users = _repository.GetUserById(id);
        return Ok(users);
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] User user)
    {
        bool status = _repository.AddUser(user);
        if (status)
        {
            return Ok("user added successfully");
        }
        else
        {
            return BadRequest("error");
        }
    }

    [HttpDelete("{id}")]
    public IActionResult RemoveUser( int id)
    {
        bool status = _repository.RemoveUser(id);
        if (status)
        {
            return Ok("user deleted successfully");
        }
        else
        {
            return BadRequest("error");
        }
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser([FromBody] int id, User user)
    {
        bool status = _repository.UpdateUser(id, user);
        if (status)
        {
            return Ok("User updated successfully");
        }
        return BadRequest("error");
    }

}