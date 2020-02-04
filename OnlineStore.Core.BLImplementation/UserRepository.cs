using OnlineStore.Core.BL;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace OnlineStore.Core.BLImplementation
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseRepository<User> _userRepository;
        private readonly OnlineStoreDbContext _dbContext;
        public UserRepository(OnlineStoreDbContext DbContext)
        {
            _userRepository = new BaseRepository<User>(DbContext);
            _dbContext = DbContext;
        }
        #region Users
        public int AddUser(User _users)
        {
            return _userRepository.Add(_users).UserID;
        }

        public int UpdateUser(User _users)
        {
            return _userRepository.Update(_users);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public User GetUserByID(int _id)
        {
            return _userRepository.GetById(_id);
        }

        public User GetUserByEmailID(string Email)
        {
            var _User = _userRepository.GetAll().Where(user => user.EmailID == Email).FirstOrDefault();
            return _User ?? null;
        }

        public void updatePasswordByID(int UserID, string Password)
        {
            _dbContext.Database.ExecuteSqlCommand("Update_PasswordByID {0},{1}", UserID, Password);
        }

        public BLModel.Paged.User GetUsersByName(string Name, int Skip, int Take)
        {           
            return new BLModel.Paged.User
            {
                UserDetails = _dbContext.Users.FromSql($"Get_UsersByName {Name},{Skip},{Take}").ToList(),
                TotalCount = _dbContext.BasePaged.FromSql($"Get_UsersByNameCount {Name}").Select(BP => BP.TotalCount).FirstOrDefault()
            };
        }
        #endregion
    }
}
 