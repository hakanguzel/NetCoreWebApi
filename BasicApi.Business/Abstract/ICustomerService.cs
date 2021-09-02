using System.Threading.Tasks;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Abstract
{
    public interface ICustomerService
    {
        public Task<ServiceResponse<CustomerDto>> GetCustomerList();
        public Task<ServiceResponse<CustomerDto>> GetCustomerById(int id);
        public Task<ServiceResponse<CustomerDto>> SaveCustomer(CustomerDto modelDto);
        public Task<ServiceResponse<CustomerDto>> DeleteCustomerById(int id);
    }
}
