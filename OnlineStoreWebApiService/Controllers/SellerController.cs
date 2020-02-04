using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Core.BL;
using OnlineStore.Core.BLImplementation;
using OnlineStore.Core.Data.SQLServer;
using OnlineStoreService.DTO;
using Paged = OnlineStoreService.DTO.Paged;
using System;

namespace OnlineStoreWebApiService.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class SellerController : ControllerBase
    {
        private ISellerRepository _sellerRepository;
        private readonly IMapper _mapper;
        public SellerController(OnlineStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _sellerRepository = new SellerRepositoryImpl(context);
        }


        [HttpPost("api/Seller/AddSellerProfile/{sellerProfile}")]
        public ActionResult AddSellerProfile(SellerProfile sellerProfile)
        {
            int sellerProfileID = _sellerRepository.AddSellerProfile(_mapper.Map<OnlineStore.Core.Data.Model.SellerProfile>(sellerProfile));
            return sellerProfileID == 0 ? NotFound(sellerProfileID) : (ActionResult)Ok(sellerProfileID);
        }

        [HttpPut("api/Seller/UpdateSellerProfile/{sellerProfile}")]
        public ActionResult UpdateSellerProfile(SellerProfile sellerProfile)
        {
            int sellerProfileID = _sellerRepository.UpdateSellerProfile(_mapper.Map<OnlineStore.Core.Data.Model.SellerProfile>(sellerProfile));
            return sellerProfileID == 0 ? NotFound(sellerProfileID) : (ActionResult)Ok(sellerProfileID);
        }

        [HttpDelete("api/Seller/DeleteSellerProfile/{id}")]
        public ActionResult DeleteSellerProfile(int id)
        {
            _sellerRepository.DeleteSellerProfile(id);
            return Ok("Product deleted Successfully");
        }

        [HttpGet("api/Seller/GetSellerProfileByID/{id}")]
        public IActionResult GetSellerProfileByID(int id)
        {
            SellerProfile sellerProfile = _mapper.Map<SellerProfile>(_sellerRepository.GetSellerProfileByID(id));
            return sellerProfile == null ? NotFound(sellerProfile) : (IActionResult)Ok(sellerProfile);
        }

        [HttpGet("api/Seller/GetSellerProfileByUserID/{userID}")]
        public IActionResult GetSellerProfileByUserID(int userID)
        {
            SellerProfile sellerProfile = _mapper.Map<SellerProfile>(_sellerRepository.GetSellerProfileByUserID(userID));
            return sellerProfile == null ? NotFound(sellerProfile) : (IActionResult)Ok(sellerProfile);
        }


    }
}