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
    public class CouponController : ControllerBase
    {
        private ICouponRepository _couponRepository;
        private readonly IMapper _mapper;
        public CouponController(OnlineStoreDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _couponRepository = new CouponRepositoryImpl(context);
        }

        [HttpPost("api/Coupon/AddCoupon/{coupon}")]
        public ActionResult AddCoupon(Coupon coupon)
        {
            int _couponID = _couponRepository.AddCoupon(_mapper.Map<OnlineStore.Core.Data.Model.Coupon>(coupon));
            return _couponID == 0 ? NotFound(_couponID) : (ActionResult)Ok(_couponID);
        }

        [HttpPut("api/Coupon/UpdateCoupon/{coupon}")]
        public ActionResult UpdateCoupon(Coupon coupon)
        {
            int _couponID = _couponRepository.UpdateCoupon(_mapper.Map<OnlineStore.Core.Data.Model.Coupon>(coupon));
            return _couponID == 0 ? NotFound(_couponID) : (ActionResult)Ok(_couponID);
        }

        [HttpDelete("api/Coupon/DeleteCoupon/{id}")]
        public ActionResult DeleteCoupon(int id)
        {
            _couponRepository.DeleteCoupon(id);
            return Ok("Product deleted Successfully");
        }

        [HttpGet("api/Coupon/GetCouponByID/{_id}")]
        public IActionResult GetCouponByID(int _id)
        {
            Coupon coupon = _mapper.Map<Coupon>(_couponRepository.GetCouponByID(_id));
            return coupon == null ? NotFound(coupon) : (IActionResult)Ok(coupon);
        }
        [HttpGet("api/Coupon/GetCouponsByCode/{CouponCode},{Skip},{Take}")]
        public Paged.Coupon GetCouponsByCode(string CouponCode, int Skip, int Take)
        {
            return _mapper.Map<Paged.Coupon>(_couponRepository.GetCouponsByCode(CouponCode, Skip, Take));
        }

    }
}