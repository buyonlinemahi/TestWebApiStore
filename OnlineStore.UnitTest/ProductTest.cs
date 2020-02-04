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
    public class ProductTest
    {
        IProductRepository _productRepository; 
        readonly OnlineStoreDbContext _context;

        public ProductTest()
        {
            var builder = new DbConnection();
            _context = new OnlineStoreDbContext((builder.InitConfiguration()).Options);
            _productRepository = new ProductRepositoryImpl(_context);
        }

        #region Product
        [Fact]
        public void Addproduct()
        {
            Product product = new Product
            {
                Title = "demo333",
                MRP = "23",
                Price = "23",
                CategoryID = 1,
                SubCategoryID = 1,
                Description = "demo333",
                
            };
            var _id = _productRepository.AddProduct(product);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateProduct()
        {
            Product product = new Product
            {
                ProductID = 4,
                Title = "jaskasran ",
                MRP = "99",
                Price = "99",
                CategoryID = 1,
                SubCategoryID = 1,
                Description = "testing",
               
            };
            var id = _productRepository.UpdateProduct(product);
            Assert.True(id > 0, "failed");
        }

        [Theory]
        [InlineData(6)]
        public void DeleteProduct(int ID)
        {
            _productRepository.DeleteProduct(ID);
        }

        [Theory]
        [InlineData(5)]
        public void GetProductByID(int ID)
        {
            var ProductByName = _productRepository.GetProductByID(ID);
            Assert.True(ProductByName != null, "failed");
        }
        #endregion

        #region ProductImage
        [Fact]
        public void AddproductImage()
        {
            ProductImage productImage = new ProductImage
            {
               ProductPhoto="demo",
                ProductID = 5
            };
            var _id = _productRepository.AddProductImage(productImage);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateProductImage()
        {
            ProductImage productImage = new ProductImage
            {
                ProductImageID = 2,
                ProductPhoto = "demo",
                ProductID = 5
            };
            var id = _productRepository.UpdateProductImage(productImage);
            Assert.True(id > 0, "failed");
        }

        [Theory]
        [InlineData(6)]
        public void DeleteProductImage(int ID)
        {
            _productRepository.DeleteProduct(ID);
        }

        [Theory]
        [InlineData(3)]
        public void GetProductImageByID(int ID)
        {
            var ProductByName = _productRepository.GetProductImageByID(ID);
            Assert.True(ProductByName != null, "failed");
        }

        #endregion

        #region ProductSpecHeading
        [Fact]
        public void Addproductspecification()
        {
            ProductSpecHeading productspec = new ProductSpecHeading
            {
                SpecHeadingTitle = "sdfsd",
                ProductID = 5,
               
            };
            var _id = _productRepository.AddProductSpecHeading(productspec);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateProductSpecification()
        {
            ProductSpecHeading productspec = new ProductSpecHeading
            {
                SpecHeadingID = 4,
                SpecHeadingTitle = "Jasssa",
                ProductID = 4,
            };
            var id = _productRepository.UpdateProductSpecHeading(productspec);
            Assert.True(id > 0, "failed");
        }

        [Theory]
        [InlineData(2)]
        public void DeleteProductSpecification(int ID)
        {
            _productRepository.DeleteProductSpecHeading(ID);
        }

        [Theory]
        [InlineData(4)]
        public void GetProductProductSpecificationByID(int ID)
        {
            var ProductByName = _productRepository.GetProductSpecHeadingByID(ID);
            Assert.True(ProductByName != null, "failed");
        }
        #endregion

        #region ProductSpecSubHeading
        [Fact]
        public void AddProductSpecSubHeading()
        {
            ProductSpecSubHeading productspec = new ProductSpecSubHeading
            {
               SubHeading = "Sub Heading 2",
               SubHeadingDescritption = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb",
               SpecHeadingID = 4

            };
            var _id = _productRepository.AddProductSpecSubHeading(productspec);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateProductSpecSubHeading()
        {
            ProductSpecSubHeading productspec = new ProductSpecSubHeading
            {
                ProductSpecSubHeadingID = 2,
                SubHeading = "Sub Heading 3",
                SubHeadingDescritption = "Cpre testtttttttttttttttttttttttttttttttttt",
                SpecHeadingID = 4
            };
            var id = _productRepository.UpdateProductSpecSubHeading(productspec);
            Assert.True(id > 0, "failed");
        }

        [Theory]
        [InlineData(2)]
        public void DeleteProductSpecSubHeading(int ID)
        {
            _productRepository.DeleteProductSpecSubHeading(ID);
        }

        [Theory]
        [InlineData(2)]
        public void GetProductSpecSubHeadingByID(int ID)
        {
            var ProductByName = _productRepository.GetProductSpecSubHeadingByID(ID);
            Assert.True(ProductByName != null, "failed");
        }
        #endregion

        #region Category
        [Fact]
        public void AddCategory()
        {
            Category category = new Category
            {
                CategoryName = "Category3"
            };
            var _id = _productRepository.AddCategory(category);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateCategory()
        {
            Category category = new Category
            {
                CategoryID = 1,
                CategoryName = "Category11"
            };
            var _id = _productRepository.UpdateCategory(category);
            Assert.True(_id > 0, "failed");
        }

        [Theory]
        [InlineData(2)]
        public void DeleteCategory(int ID)
        {
            _productRepository.DeleteCategory(ID);
        }
        [Fact]       
        public void GetCategoriesLikeCategoryName()
        {
            var categories = _productRepository.GetCategoriesLikeCategoryName("Cat");
            Assert.True(categories != null, "failed");
        }
        //[Theory]
        //[InlineData(3)]
        //public void GetCategoryByID(int ID)
        //{
        //    var ProductByName = _productRepository.GetProductSpecificationDetailByID(ID);
        //    Assert.True(ProductByName != null, "failed");
        //}
        #endregion

        #region SubCategory
        [Fact]
        public void AddSubCategory()
        {
            SubCategory subCategory = new SubCategory
            {
                SubCategoryName = "SubCategory3",
                CategoryID = 1
            };
            var _id = _productRepository.AddSubCategory(subCategory);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void UpdateSubCategory()
        {
            SubCategory subCategory = new SubCategory
            {
                SubCategoryID = 2,
                SubCategoryName = "SubCategory33",
                CategoryID = 2
            };
            var _id = _productRepository.UpdateSubCategory(subCategory);
            Assert.True(_id > 0, "failed");
        }

        [Theory]
        [InlineData(3)]
        public void DeleteSubCategory(int ID)
        {
            _productRepository.DeleteSubCategory(ID);
        }

        [Theory]
        [InlineData(3)]
        public void GetSubCategoryByID(int ID)
        {
            var ProductByName = _productRepository.GetSubCategoryByID(ID);
            Assert.True(ProductByName != null, "failed");
        }
        [Fact]
        public void GetSubCategoriesLikeSubCategoryName()
        {
            var subcategories = _productRepository.GetSubCategoriesLikeSubCategoryName("Sub");
            Assert.True(subcategories != null, "failed");
        }
        #endregion

        #region Productinventory
        [Fact]
        public void Addproductinventory()
        {
            Productinventory productinventory = new Productinventory
            {
                SKU = "77777777",
                IsManageStock = false,
                StockStatusID = 1,
                MeasurementUnitID = 5,
                ProductIID = 47
            };
            var _id = _productRepository.AddProductinventory(productinventory);
            Assert.True(_id > 0, "failed");
        }

        [Fact]
        public void Updateproductinventory()
        {
            Productinventory productinventory = new Productinventory
            {
                ProductInventoryID = 2,
                SKU = "00000000000",
                IsManageStock = false,
                StockStatusID = 2,
                MeasurementUnitID = 6,
                ProductIID = 50

            };
            var id = _productRepository.UpdateProductinventory(productinventory);
            Assert.True(id > 0, "failed");
        }

        [Theory]
        [InlineData(4)]
        public void Deleteproductinventory(int ID)
        {
            _productRepository.DeleteProductinventory(ID);
        }

        [Theory]
        [InlineData(2)]
        public void GetproductinventoryByID(int ID)
        {
            var ProductinventoryByName = _productRepository.GetProductinventoryByID(ID);
            Assert.True(ProductinventoryByName != null, "failed");
        } 
        #endregion

    }
}


