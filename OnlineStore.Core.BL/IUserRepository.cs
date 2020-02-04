using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;

namespace OnlineStore.Core.BL
{
    public interface IUserRepository
    {
        #region Users
        int AddUser(User users);
        int UpdateUser(User users);
        void DeleteUser(int id);
        User GetUserByID(int _id);
        User GetUserByEmailID(string Name);
        BLModel.Paged.User GetUsersByName(string name, int _skip, int _take);
        //int updatePasswordOTPByID(int userID, string passwordOTP);
        void updatePasswordByID(int userID, string newPassword);
        //bool ConfirmOTP(string OTP, int UserID);
        //PasswordHistory GetOldPasswordByUserID(int userID);
        #endregion
    }
}
