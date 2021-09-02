using System;
using System.Threading.Tasks;
using BasicApi.Business.Abstract;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Concrete
{
    public class SaleService : ISaleService
    {
        public Task<ServiceResponse<SaleDto>> DeleteOrderById(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SaleDto>> OrderDetail(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SaleDto>> OrderList(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<SaleDto>> SaveOrder(int userId, SaleDto modelDto)
        {
            throw new NotImplementedException();
        }
    }
}
