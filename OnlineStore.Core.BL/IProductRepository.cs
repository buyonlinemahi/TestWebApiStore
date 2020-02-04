using OnlineStore.Core.Data.Model;
using OnlineStore.Core.Data.SQLServer;
using System.Collections.Generic;

namespace OnlineStore.Core.BL
{
   public  interface IProductRepository
    {
        #region Product
        int AddProduct(Product products);
        int UpdateProduct(Product products);
        void DeleteProduct(int id);
        Product GetProductByID(int _id);
        #endregion

        #region ProductImage
        int AddProductImage(ProductImage productImage);
        int UpdateProductImage(ProductImage productImage);
        void DeleteProductImage(int id);
        ProductImage GetProductImageByID(int _id);
        #endregion

        #region ProductSpecHeading
        int AddProductSpecHeading(ProductSpecHeading productSpecHeading);
        int UpdateProductSpecHeading(ProductSpecHeading productSpecHeading);
        void DeleteProductSpecHeading(int id);
        ProductSpecHeading GetProductSpecHeadingByID(int _id);
        #endregion

        #region ProductSpecSubHeading
        int AddProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading);
        int UpdateProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading);
        void DeleteProductSpecSubHeading(int id);
        ProductSpecSubHeading GetProductSpecSubHeadingByID(int _id);
        #endregion

        #region Category
        int AddCategory(Category category);
        int UpdateCategory(Category category);
        void DeleteCategory(int id);
        Category GetCategoryByID(int _id);
        IEnumerable<Category> GetCategoriesLikeCategoryName(string searchText);
        #endregion

        #region SubCategory
        int AddSubCategory(SubCategory subCategory);
        int UpdateSubCategory(SubCategory subCategory);
        void DeleteSubCategory(int id);
        SubCategory GetSubCategoryByID(int _id);
        IEnumerable<SubCategory> GetSubCategoriesLikeSubCategoryName(string searchText);
        #endregion

        #region Productinventory
        int AddProductinventory(Productinventory productinventory);
        int UpdateProductinventory(Productinventory productinventory);
        void DeleteProductinventory(int id);
        Productinventory GetProductinventoryByID(int _id); 
        #endregion





    }
}
