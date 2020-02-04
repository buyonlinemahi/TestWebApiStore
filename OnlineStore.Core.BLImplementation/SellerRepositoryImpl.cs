using OnlineStore.Core.BL;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Omu.ValueInjecter;

namespace OnlineStore.Core.BLImplementation
{
    public class SellerRepositoryImpl : ISellerRepository
    {
        private readonly BaseRepository<SellerProfile> _sellerProfileRepository;

        public SellerRepositoryImpl(OnlineStoreDbContext DbContext)
        {
            _sellerProfileRepository = new BaseRepository<SellerProfile>(DbContext);          
        }


        public int AddSellerProfile(SellerProfile sellerProfile)
        {
            return _sellerProfileRepository.Add(sellerProfile).SellerProfileID;
        }

        public int UpdateSellerProfile(SellerProfile sellerProfile)
        {
            return _sellerProfileRepository.Update(sellerProfile);
        }

        public void DeleteSellerProfile(int id)
        {
            _sellerProfileRepository.Delete(id);
        }

        public SellerProfile GetSellerProfileByID(int _id)
        {
            return _sellerProfileRepository.GetById(_id);
        }

        public SellerProfile GetSellerProfileByUserID(int userID)
        {
            var _sellerProfile = _sellerProfileRepository.GetAll().Where(SP => SP.UserID == userID).FirstOrDefault();
            return _sellerProfile ?? null;
        }
    }
}
