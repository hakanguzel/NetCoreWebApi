using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BasicApi.Business.Abstract;
using BasicApi.Core.Abstract;
using BasicApi.Data.DataAccess;
using BasicApi.Data.DtoModels;
using Microsoft.EntityFrameworkCore;

namespace BasicApi.Business.Concrete
{
    public class CustomerService : ICustomerService
    {
        private IRepository<Customer> _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(IRepository<Customer> customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<CustomerDto>> DeleteCustomerById(int id)
        {
            var response = new ServiceResponse<CustomerDto>(null);
            try
            {

                var item = await _customerRepository.TableNoTracking.FirstOrDefaultAsync(x =>
                    x.Id == id);
                if (item != null)
                {
                    item.Deleted = true;
                    await _customerRepository.Update(item);
                    response.IsSuccessful = true;
                }
                else
                {
                    response.IsSuccessful = false;
                }

            }
            catch
            {
                response.IsSuccessful = false;
            }

            return response;
        }

        public async Task<ServiceResponse<CustomerDto>> GetCustomerById(int id)
        {
            var response = new ServiceResponse<CustomerDto>(null);
            try
            {
                var data = await _customerRepository.TableNoTracking.FirstOrDefaultAsync(a =>
                    a.Id == id && a.Deleted == false);


                response.Entity = _mapper.Map<CustomerDto>(data);
                response.IsSuccessful = true;
            }
            catch
            {
                response.IsSuccessful = false;
            }

            return response;
        }

        public async Task<ServiceResponse<CustomerDto>> GetCustomerList()
        {
            var response = new ServiceResponse<CustomerDto>(null);
            try
            {
                var data = await _customerRepository.TableNoTracking
                    .Where(a => a.Deleted == false).ToListAsync();

                response.List = _mapper.Map<IList<CustomerDto>>(data);
                response.IsSuccessful = true;
                response.Count = response.List.Count();
            }
            catch
            {
                response.IsSuccessful = false;
            }

            return response;
        }

        public async Task<ServiceResponse<CustomerDto>> SaveCustomer(CustomerDto modelDto)
        {
            var response = new ServiceResponse<CustomerDto>(null);
            try
            {

                var model = _mapper.Map<Customer>(modelDto);
                if (model.Id > 0)
                {
                    await _customerRepository.Update(model);
                    response.IsSuccessful = true;
                }
                else
                {
                    model.Deleted = false;
                    model.CreateDate = DateTime.Now;

                    await _customerRepository.Insert(model);
                    response.IsSuccessful = true;
                }
            }
            catch
            {
                response.IsSuccessful = false;
            }

            return response;
        }
    }
}
