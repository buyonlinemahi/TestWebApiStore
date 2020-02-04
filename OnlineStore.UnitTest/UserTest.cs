using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using System;
using Xunit;

namespace OnlineStore.UnitTest
{
    public class UserTest
    {
        IUserRepository _userRepository;
        readonly OnlineStoreDbContext _context;

        public UserTest()
        {
            var builder = new DbConnection();
            _context = new OnlineStoreDbContext((builder.InitConfiguration()).Options);
            _userRepository = new UserRepository(_context);
        }

        #region Users
        [Fact]
        public void Adduser()
        {
            User _user = new User
            {
                FirstName = "jaskarn Test",
                LastName = "singh",
                EmailID = "jasingh@vsaindia.com",
                Password = "qwerty@12345",
                Phone = "9915313852",
                IsActive = true,
                ClearedOn = DateTime.Now,
                UserTypeID  = 1

            };
            var id = _userRepository.AddUser(_user);
            Assert.True(id > 0, "failed");

        }

        [Fact]
        public void UpdateUser()
        {
            User _user = new User
            {
                UserID = 2,
                FirstName = "UPDateTestFName",
                LastName = "UpDateTestLName",
                EmailID = "dsharma@test.com",
                Password = "UPdateabcsasd",
                Phone = "98985638888",
                IsActive = true,
                ClearedOn = DateTime.Now
            };
            var id = _userRepository.UpdateUser(_user);
            Assert.True(id > 0, "failed");
        }


        [Theory]
        [InlineData(4)]
        public void DeleteUser(int ID)
        {
            _userRepository.DeleteUser(ID);
        }

        [Theory]
        [InlineData(2)]
        public void GetUserByID(int ID)
        {
            var userByName = _userRepository.GetUserByID(ID);
            Assert.True(userByName != null, "failed");
        }

        [Fact]
        public void GetUserByEmailID()
        {
            var userByName = _userRepository.GetUserByEmailID("dsharma@test.com");
            Assert.True(userByName != null, "failed");
        }
        [Fact]
        public void updatePasswordByID()
        {
          _userRepository.updatePasswordByID(2,"Vsa@123");
           
        }
        [Fact]
        public void GetUsers()
        {
            var userByName = _userRepository.GetUsersByName("",0, 50);
            Assert.True(userByName != null, "failed");
        }
        #endregion
    }
}
