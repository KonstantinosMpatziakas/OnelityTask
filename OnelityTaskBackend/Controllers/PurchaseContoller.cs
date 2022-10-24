using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnelityTaskBackend.Interfaces;
using OnelityTaskBackend.Models;

namespace OnelityTaskBackend.Controllers
{
    public class PurchaseContoller : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PurchaseContoller(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        [HttpPost("InsertPurchases")]
        public async Task<IActionResult> InsertUser([FromBody] Purchase model)
        {
            var purchase = new Purchase()
            {
                Id = model.Id,
                Name = model.Name,
            };

            _unitOfWork.Purchases.Add(purchase);
            _unitOfWork.Complete();

            return Ok(purchase);
        }

        [HttpGet("GetPurchases")]
        public async Task<IActionResult> GetPurchases()
        {
            List<Purchase> res = new List<Purchase>();
            foreach (Purchase p in _unitOfWork.Purchases.GetAll())
            {
                res.Add(p);
            }

            return Ok(res);
        }

    }
}
