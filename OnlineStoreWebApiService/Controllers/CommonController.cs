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
    public class CommonController : ControllerBase
    {
        private ICommonRepository commonRepository;
        private readonly IMapper _mapper;
        public CommonController(OnlineStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            commonRepository = new CommonRepositoryImpl(context);
        }

        [HttpGet("api/Common/GetUserTypes")]
        public IEnumerable<UserType> GetUserTypes()
        {
            return _mapper.Map<IEnumerable<UserType>>(commonRepository.GetUserTypes());
        }

        [HttpGet("api/Common/getAllCategory")]
        public IEnumerable<Category> getAllCategory()
        {
            return _mapper.Map<IEnumerable<Category>>(commonRepository.getAllCategory());
        }

        [HttpGet("api/Common/getAllSubCategory")]
        public IEnumerable<SubCategory> getAllSubCategory()
        {
            return _mapper.Map<IEnumerable<SubCategory>>(commonRepository.getAllSubCategory());
        }
        [HttpGet("api/Common/GetSubCategoryByCategoryID/{categoryID}")]
        public IEnumerable<SubCategory> GetSubCategoryByCategoryID(int categoryID)
        {
            return _mapper.Map<IEnumerable<SubCategory>>(commonRepository.GetSubCategoryByCategoryID(categoryID));
        }
        [HttpGet("api/Common/GetDiscountTypes")]
        public IEnumerable<DiscountType> GetDiscountTypes()
        {
            return _mapper.Map<IEnumerable<DiscountType>>(commonRepository.GetDiscountTypes());
        }

        [HttpGet("api/Common/GetAllProducttypes")]
        public IEnumerable<Product> GetAllProducttypes()
        {
            return _mapper.Map<IEnumerable<Product>>(commonRepository.GetAllProducttypes());
        }

        [HttpGet("api/Common/GetAllSpecHeading")]
        public IEnumerable<ProductSpecHeading> GetAllSpecHeading()
        {
            return _mapper.Map<IEnumerable<ProductSpecHeading>>(commonRepository.GetAllSpecHeading());
        }

        [HttpGet("api/Common/GetAllStatuses")]
        public IEnumerable<StockStatus> GetAllStatuses()
        {
            return _mapper.Map<IEnumerable<StockStatus>>(commonRepository.GetAllStatuses());
        }

        [HttpGet("api/Common/GetAllUnitMeasurement")]
        public IEnumerable<UnitMeasurement> GetAllUnitMeasurement()
        {
            return _mapper.Map<IEnumerable<UnitMeasurement>>(commonRepository.GetAllUnitMeasurement());
        }
    }
}