using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Abstract
{
    public interface ISaleService
    {
        Task<ServiceResponse<SaleDto>> OrderList(int userId);
        Task<ServiceResponse<SaleDto>> OrderDetail(int userId, int id);
        Task<ServiceResponse<SaleDto>> SaveOrder(int userId, SaleDto modelDto);
        Task<ServiceResponse<SaleDto>> DeleteOrderById(int userId, int id);
    }
}
