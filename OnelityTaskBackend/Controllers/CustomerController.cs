using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnelityTaskBackend.Interfaces;
using OnelityTaskBackend.Models;

namespace OnelityTaskBackend.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        [HttpPost("InsertUser")]
        public async Task<IActionResult> InsertUser([FromBody] Customer model)
        {
            var customer = new Customer()
            {
                Id = model.Id,
                Name = model.Name,
            };

            _unitOfWork.Customers.Add(customer);
            _unitOfWork.Complete();

            return Ok(customer);
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            List<Customer> res = new List<Customer>();
            foreach(Customer c in _unitOfWork.Customers.GetAll())
            {
                res.Add(c);
            }

            return Ok(res);
        }
    }
}
