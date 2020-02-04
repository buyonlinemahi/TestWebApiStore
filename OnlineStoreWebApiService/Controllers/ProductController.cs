using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.SQLServer;
using OnlineStoreService.DTO;
using Paged = OnlineStoreService.DTO.Paged;
using System;
using System.Collections.Generic;

namespace OnlineStoreWebApiService.Controllers
{
   
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private IProductRepository productRepository;
        private readonly IMapper _mapper;
        public ProductController(OnlineStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            productRepository = new ProductRepositoryImpl(context);
        }

        #region Product
        [HttpPost("api/Product/AddProduct/{products}")]
        public ActionResult AddProduct(Product products)
        {
            int ProductID = productRepository.AddProduct(_mapper.Map<OnlineStore.Core.Data.Model.Product>(products));
            return ProductID == 0 ? NotFound(ProductID) : (ActionResult)Ok(ProductID);
        }

        [HttpPut("api/Product/UpdateProduct/{products}")]
        public ActionResult UpdateProduct(Product products)
        {
            int ProductId = productRepository.UpdateProduct(_mapper.Map<OnlineStore.Core.Data.Model.Product>(products));
            return ProductId == 0 ? NotFound(ProductId) : (ActionResult)Ok(ProductId);
        }

        [HttpDelete("api/Product/DeleteProduct/{id}")]
        public ActionResult DeleteProduct(int id)
        {
            productRepository.DeleteProduct(id);
            return Ok("Product deleted Successfully");
        }

        [HttpGet("api/Product/GetProductByID/{id}")]
        public IActionResult GetProductByID(int id)
        {
            Product product = _mapper.Map<Product>(productRepository.GetProductByID(id));
            return product == null ? NotFound(product) : (IActionResult)Ok(product);
        }
        #endregion

        #region ProductImage
        [HttpPost("api/Product/AddProductImage/{productImage}")]
        public ActionResult AddProductImage(ProductImage productImage)
        {
            int ProductImageID = productRepository.AddProductImage(_mapper.Map<OnlineStore.Core.Data.Model.ProductImage>(productImage));
            return ProductImageID == 0 ? NotFound(ProductImageID) : (ActionResult)Ok(ProductImageID);
        }

        [HttpPut("api/Product/UpdateProductImage/{productImage}")]
        public ActionResult UpdateProductImage(ProductImage productImage)
        {
            int ProductImageId = productRepository.UpdateProductImage(_mapper.Map<OnlineStore.Core.Data.Model.ProductImage>(productImage));
            return ProductImageId == 0 ? NotFound(ProductImageId) : (ActionResult)Ok(ProductImageId);
        }

        [HttpDelete("api/Product/DeleteProductImage/{id}")]
        public ActionResult DeleteProductImage(int id)
        {
            productRepository.DeleteProductImage(id);
            return Ok("ProductImage deleted Successfully");
        }

        [HttpGet("api/Product/GetProductImageByID/{id}")]
        public IActionResult GetProductImageByID(int id)
        {
            ProductImage productImage = _mapper.Map<ProductImage>(productRepository.GetProductImageByID(id));
            return productImage == null ? NotFound(productImage) : (IActionResult)Ok(productImage);
        }

        #endregion

        #region ProductSpecHeading
        [HttpPost("api/Product/AddProductSpecHeading/{productSpecHeading}")]
        public ActionResult AddProductSpecHeading(ProductSpecHeading productSpecHeading)
        {
            int SpecHeadingID = productRepository.AddProductSpecHeading(_mapper.Map<OnlineStore.Core.Data.Model.ProductSpecHeading>(productSpecHeading));
            return SpecHeadingID == 0 ? NotFound(SpecHeadingID) : (ActionResult)Ok(SpecHeadingID);
        }

        [HttpPut("api/Product/UpdateProductSpecHeading/{productSpecHeading}")]
        public ActionResult UpdateProductSpecHeading(ProductSpecHeading productSpecHeading)
        {
            int SpecHeadingID = productRepository.UpdateProductSpecHeading(_mapper.Map<OnlineStore.Core.Data.Model.ProductSpecHeading>(productSpecHeading));
            return SpecHeadingID == 0 ? NotFound(SpecHeadingID) : (ActionResult)Ok(SpecHeadingID);
        }

        [HttpDelete("api/Product/DeleteProductSpecHeading/{id}")]
        public ActionResult DeleteProductSpecHeading(int id)
        {
            productRepository.DeleteProductSpecHeading(id);
            return Ok("ProductSpecHeading deleted Successfully");
        }

        [HttpGet("api/Product/GetProductSpecHeadingByID/{id}")]
        public IActionResult GetProductSpecHeadingByID(int id)
        {
            ProductSpecHeading productSpecHeading = _mapper.Map<ProductSpecHeading>(productRepository.GetProductSpecHeadingByID(id));
            return productSpecHeading == null ? NotFound(productSpecHeading) : (IActionResult)Ok(productSpecHeading);
        }

        #endregion

        #region ProductSpecSubHeading
        [HttpPost("api/Product/AddProductSpecSubHeading/{productSpecSubHeading}")]
        public ActionResult AddProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading)
        {
            int ProductSpecSubHeadingID = productRepository.AddProductSpecSubHeading(_mapper.Map<OnlineStore.Core.Data.Model.ProductSpecSubHeading>(productSpecSubHeading));
            return ProductSpecSubHeadingID == 0 ? NotFound(ProductSpecSubHeadingID) : (ActionResult)Ok(ProductSpecSubHeadingID);
        }

        [HttpPut("api/Product/UpdateProductSpecSubHeading/{productSpecSubHeading}")]
        public ActionResult UpdateProductSpecSubHeading(ProductSpecSubHeading productSpecSubHeading)
        {
            int ProductSpecSubHeadingID = productRepository.UpdateProductSpecSubHeading(_mapper.Map<OnlineStore.Core.Data.Model.ProductSpecSubHeading>(productSpecSubHeading));
            return ProductSpecSubHeadingID == 0 ? NotFound(ProductSpecSubHeadingID) : (ActionResult)Ok(ProductSpecSubHeadingID);
        }

        [HttpDelete("api/Product/DeleteProductSpecSubHeading/{id}")]
        public ActionResult DeleteProductSpecSubHeading(int id)
        {
            productRepository.DeleteProductSpecSubHeading(id);
            return Ok("ProductSpecHeading deleted Successfully");
        }

        [HttpGet("api/Product/GetProductSpecSubHeadingByID/{id}")]
        public IActionResult GetProductSpecSubHeadingByID(int id)
        {
            ProductSpecSubHeading productSpecSubHeading = _mapper.Map<ProductSpecSubHeading>(productRepository.GetProductSpecSubHeadingByID(id));
            return productSpecSubHeading == null ? NotFound(productSpecSubHeading) : (IActionResult)Ok(productSpecSubHeading);
        }

        #endregion

        #region Category
        [HttpPost("api/Product/AddCategory/{category}")]
        public ActionResult AddCategory(Category category)
        {
            int categoryID = productRepository.AddCategory(_mapper.Map<OnlineStore.Core.Data.Model.Category>(category));
            return categoryID == 0 ? NotFound(categoryID) : (ActionResult)Ok(categoryID);
        }

        [HttpPut("api/Product/UpdateCategory/{category}")]
        public ActionResult UpdateCategory(Category category)
        {
            int categoryID = productRepository.UpdateCategory(_mapper.Map<OnlineStore.Core.Data.Model.Category>(category));
            return categoryID == 0 ? NotFound(categoryID) : (ActionResult)Ok(categoryID);
        }

        [HttpDelete("api/Product/DeleteCategory/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            productRepository.DeleteCategory(id);
            return Ok("Category deleted Successfully");
        }

        [HttpGet("api/Product/GetCategoryByID/{id}")]
        public IActionResult GetCategoryByID(int id)
        {
            Category category = _mapper.Map<Category>(productRepository.GetCategoryByID(id));
            return category == null ? NotFound(category) : (IActionResult)Ok(category);
        }
        [HttpGet("api/Product/GetCategoriesLikeCategoryName/{searchText}")]
        public IActionResult GetCategoriesLikeCategoryName(string searchText)
        {
            var category = productRepository.GetCategoriesLikeCategoryName(searchText);
            return category == null ? NotFound(category) : (IActionResult)Ok(category);
        }
        #endregion

        #region SubCategory
        [HttpPost("api/Product/AddSubCategory/{subCategory}")]
        public ActionResult AddSubCategory(SubCategory subCategory)
        {
            int SubCategoryID = productRepository.AddSubCategory(_mapper.Map<OnlineStore.Core.Data.Model.SubCategory>(subCategory));
            return SubCategoryID == 0 ? NotFound(SubCategoryID) : (ActionResult)Ok(SubCategoryID);
        }

        [HttpPut("api/Product/UpdateSubCategory/{subCategory}")]
        public ActionResult UpdateSubCategory(SubCategory subCategory)
        {
            int categoryID = productRepository.UpdateSubCategory(_mapper.Map<OnlineStore.Core.Data.Model.SubCategory>(subCategory));
            return categoryID == 0 ? NotFound(categoryID) : (ActionResult)Ok(categoryID);
        }

        [HttpDelete("api/Product/DeleteSubCategory/{id}")]
        public ActionResult DeleteSubCategory(int id)
        {
            productRepository.DeleteSubCategory(id);
            return Ok("SubCategory deleted Successfully");
        }

        [HttpGet("api/Product/GetSubCategoryByID/{id}")]
        public IActionResult GetSubCategoryByID(int id)
        {
            SubCategory subCategory = _mapper.Map<SubCategory>(productRepository.GetSubCategoryByID(id));
            return subCategory == null ? NotFound(subCategory) : (IActionResult)Ok(subCategory);
        }
        [HttpGet("api/Product/GetSubCategoriesLikeSubCategoryName/{searchText}")]
        public IActionResult GetSubCategoriesLikeSubCategoryName(string searchText)
        {
            var subcategory =productRepository.GetSubCategoriesLikeSubCategoryName(searchText);
            return subcategory == null ? NotFound(subcategory) : (IActionResult)Ok(subcategory);
        }
        #endregion

        #region Productinventory
        [HttpPost("api/Product/AddProductInventroy/{productinventory}")]
        public ActionResult AddProductInventroy(Productinventory productinventory)
        {
            int productInventoryyID = productRepository.AddProductinventory(_mapper.Map<OnlineStore.Core.Data.Model.Productinventory>(productinventory));
            return productInventoryyID == 0 ? NotFound(productInventoryyID) : (ActionResult)Ok(productInventoryyID);
        }

        [HttpPut("api/Product/UpdateProductinventory/{productinventory}")]
        public ActionResult UpdateProductinventory(Productinventory productinventory)
        {
            int productInventoryyID = productRepository.UpdateProductinventory(_mapper.Map<OnlineStore.Core.Data.Model.Productinventory>(productinventory));
            return productInventoryyID == 0 ? NotFound(productInventoryyID) : (ActionResult)Ok(productInventoryyID);
        }

        [HttpDelete("api/Product/DeleteProductinventory/{id}")]
        public ActionResult DeleteProductinventory(int id)
        {
            productRepository.DeleteProductinventory(id);
            return Ok("Productinventory deleted Successfully");
        }

        [HttpGet("api/Product/GetProductinventoryByID/{id}")]
        public IActionResult GetProductinventoryByID(int id)
        {
            Productinventory productinventory = _mapper.Map<Productinventory>(productRepository.GetProductinventoryByID(id));
            return productinventory == null ? NotFound(productinventory) : (IActionResult)Ok(productinventory);
        } 
        #endregion

    }
}