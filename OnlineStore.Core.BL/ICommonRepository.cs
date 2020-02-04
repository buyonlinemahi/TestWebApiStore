
using System.Collections.Generic;
using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;

namespace OnlineStore.Core.BL
{
    public interface ICommonRepository
    {
        IEnumerable<Category> getAllCategory();
        IEnumerable<SubCategory> getAllSubCategory();
        IEnumerable<SubCategory> GetSubCategoryByCategoryID(int categoryID);
        IEnumerable<UserType> GetUserTypes();
        IEnumerable<DiscountType> GetDiscountTypes();
        IEnumerable<Product> GetAllProducttypes();
        IEnumerable<ProductSpecHeading> GetAllSpecHeading();
        IEnumerable<StockStatus> GetAllStatuses();
        IEnumerable<UnitMeasurement> GetAllUnitMeasurement();
    }
}
