using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;

namespace OnlineStore.Core.BL
{
    public interface ISellerRepository
    {
        int AddSellerProfile(SellerProfile sellerProfile);
        int UpdateSellerProfile(SellerProfile sellerProfile);
        void DeleteSellerProfile(int id);
        SellerProfile GetSellerProfileByID(int _id);
        SellerProfile GetSellerProfileByUserID(int userID);
    }
}
