using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicApi.Business.Abstract;
using BasicApi.Data.DataAccess;
using BasicApi.Data.DtoModels;
using Microsoft.AspNetCore.Mvc;


namespace BasicApi.WebApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet("GetCustomerList")]
        public async Task<ServiceResponse<CustomerDto>> GetCustomerList()
        {
            return await _customerService.GetCustomerList();
        }


        [HttpGet("GetCustomerById/{id}")]
        public async Task<ServiceResponse<CustomerDto>> GetCustomerById(int id)
        {
            return await _customerService.GetCustomerById(id);
        }


        [HttpPost("SaveCustomer")]
        public async Task<ServiceResponse<CustomerDto>> SaveCustomer(CustomerDto modelDto)
        {
            return await _customerService.SaveCustomer(modelDto);
        }


        [HttpDelete("DeleteCustomerById/{id}")]
        public async Task<ServiceResponse<CustomerDto>> DeleteCustomerById(int id)
        {
            return await _customerService.DeleteCustomerById(id);
        }
    }
}
