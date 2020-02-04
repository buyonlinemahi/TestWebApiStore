using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.SQLServer;
using OnlineStoreService.DTO;
using Paged = OnlineStoreService.DTO.Paged;

using System;

namespace OnlineStoreWebApiService.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserController(OnlineStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = new UserRepository(context);
        }

        [HttpGet("api/User")]
        public String User()
        {
            return "Wellcome in User API";
        }

        [HttpGet("api/User/GetUserByID/{Id}")]
        public IActionResult GetUserByID(int Id)
        {
            User _user = _mapper.Map<User>(_userRepository.GetUserByID(Id));
            return _user == null ? NotFound(_user) : (IActionResult)Ok(_user);

        }

        [HttpGet("api/User/GetByEmailID/{Email}")]
        public IActionResult GetByEmailID(string Email)
        {
            User _user = _mapper.Map<User>(_userRepository.GetUserByEmailID(Email));
            return _user == null ? NotFound(_user) : (IActionResult)Ok(_user);
        }

        [HttpPut("api/User/UpdateUser/{_users}")]
        public ActionResult UpdateUser(User _users)
        {
            int UserId = _userRepository.UpdateUser(_mapper.Map<OnlineStore.Core.Data.Model.User>(_users));
            return UserId == 0 ? NotFound(UserId) : (ActionResult)Ok(UserId);
        }

        [HttpDelete("api/User/DeleteUser/{id}")]
        public ActionResult DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
            return Ok("User deleted Successfully");
        }

        [HttpPost("api/User/AddUser/{_users}")]
        public ActionResult AddUser(User _users)
        {
            int UserID = _userRepository.AddUser(_mapper.Map<OnlineStore.Core.Data.Model.User>(_users));
            return UserID == 0 ? NotFound(UserID) : (ActionResult)Ok(UserID);
            //return BadRequest(ex.Message.ToString());
        }
        [HttpGet("api/User/GetUsersByName/{Name},{Skip},{Take}")]
        public Paged.User GetUsersByName(string Name, int Skip, int Take)
        {
           return _mapper.Map<Paged.User>(_userRepository.GetUsersByName(Name, Skip, Take));
        }
        [HttpPut("api/User/updatePasswordByID/{userID},{newPassword}")]
        public void updatePasswordByID(int userID, string newPassword)
        {
            _userRepository.updatePasswordByID(userID, newPassword);
        }

    }
}
