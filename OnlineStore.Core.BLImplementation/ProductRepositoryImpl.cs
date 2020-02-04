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
    public class ProductRepositoryImpl   : IProductRepository
    {
        private readonly BaseRepository<Product> _productRepository;
        private readonly BaseRepository<ProductImage> __productImageRepository;
        private readonly BaseRepository<ProductSpecHeading> _productSpecHeadingRepository;
        private readonly BaseRepository<Category> _categoryRepository;
        private readonly BaseRepository<SubCategory> _subCategoryRepository;
        private readonly BaseRepository<ProductSpecSubHeading> _productSpecSubHeading;
        private readonly BaseRepository<Productinventory> _productInventoryRespository;
        public ProductRepositoryImpl(OnlineStoreDbContext DbContext)
        {
            _productRepository = new BaseRepository<Product>(DbContext);
            __productImageRepository = new BaseRepository<ProductImage>(DbContext);
            _productSpecHeadingRepository = new BaseRepository<ProductSpecHeading>(DbContext);
            _categoryRepository = new BaseRepository<Category>(DbContext);
            _subCategoryRepository = new BaseRepository<SubCategory>(DbContext);
            _productSpecSubHeading = new BaseRepository<ProductSpecSubHeading>(DbContext);
            _productInventoryRespository = new BaseRepository<Productinventory>(DbContext);
        }

        #region Product
        public int AddProduct(Product products)
        {
            return _productRepository.Add(products).ProductID;
        }

        public int UpdateProduct(Product products)
        {
            return _productRepository.Update(products);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.Delete(id);
        }

        public Product GetProductByID(int _id)
        {
            return _productRepository.GetById(_id);
        }

        #endregion

        #region ProductImage
        public int AddProductImage(ProductImage productImage)
        {
            return __productImageRepository.Add(productImage).ProductImageID;
        }

        public int UpdateProductImage(ProductImage productImage)
        {
            return __productImageRepository.Update(productImage);
        }

        public void DeleteProductImage(int id)
        {
            __productImageRepository.Delete(id);
        }

        public ProductImage GetProductImageByID(int _id)
        {
            return __productImageRepository.GetById(_id);
        }

        #endregion

        #region ProductSpecHeading
        public int AddProductSpecHeading(ProductSpecHeading productSpecHeading)
        {
            return _productSpecHeadingRepository.Add(productSpecHeading).SpecHeadingID;
        }

        public int UpdateProductSpecHeading(ProductSpecHeading productSpecHeading)
        {
            return _productSpecHeadingRepository.Update(productSpecHeading);
        }

        public void DeleteProductSpecHeading(int id)
        {
            _productSpecHeadingRepository.Delete(id);
        }

        public ProductSpecHeading GetProductSpecHeadingByID(int _id)
        {
            return _productSpecHeadingRepository.GetById(_id);
        }
        #endregion

        #region ProductSpecSubHeading
        public int AddProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading)
        {
            return _productSpecSubHeading.Add(productSpecSubHeading).ProductSpecSubHeadingID;
        }

        public int  UpdateProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading)
        {
            return _productSpecSubHeading.Update(productSpecSubHeading);
        }

        public void DeleteProductSpecSubHeading(int id)
        {
            _productSpecSubHeading.Delete(id);
        }

        public ProductSpecSubHeading GetProductSpecSubHeadingByID(int _id)
        {
            return _productSpecSubHeading.GetById(_id);
        }
        #endregion

        #region Category
        public int AddCategory(Category category)
        {
            return _categoryRepository.Add(category).CategoryID;
        }

        public int UpdateCategory(Category category)
        {
            return _categoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category GetCategoryByID(int _id)
        {
            return _categoryRepository.GetById(_id);
        }

       public IEnumerable<Category> GetCategoriesLikeCategoryName(string searchText)
        {
             return _categoryRepository.GetAll(cat => (cat.CategoryName.StartsWith(searchText))).Select(cat => (Category)new Category().InjectFrom(cat)).ToList();
        }
        #endregion

        #region SubCategory
        public int AddSubCategory(SubCategory subCategory)
        {
            return _subCategoryRepository.Add(subCategory).SubCategoryID;
        }

        public int UpdateSubCategory(SubCategory subCategory)
        {
            return _subCategoryRepository.Update(subCategory);
        }

        public void DeleteSubCategory(int id)
        {
            _subCategoryRepository.Delete(id);
        }

        public SubCategory GetSubCategoryByID(int _id)
        {
            return _subCategoryRepository.GetById(_id);
        }

        public IEnumerable<SubCategory> GetSubCategoriesLikeSubCategoryName(string searchText)
        {
            return _subCategoryRepository.GetAll(subCat => (subCat.SubCategoryName.StartsWith(searchText))).Select(subCat => (SubCategory)new SubCategory().InjectFrom(subCat)).ToList();
        }
        #endregion

        #region Productinventory
        public int AddProductinventory(Productinventory productinventory)
        {
            return _productInventoryRespository.Add(productinventory).ProductInventoryID;
        }

        public int UpdateProductinventory(Productinventory productinventory)
        {
            return _productInventoryRespository.Update(productinventory);
        }

        public void DeleteProductinventory(int id)
        {
            _productInventoryRespository.Delete(id);
        }

        public Productinventory GetProductinventoryByID(int _id)
        {
            return _productInventoryRespository.GetById(_id);
        } 
        #endregion

    }
}
