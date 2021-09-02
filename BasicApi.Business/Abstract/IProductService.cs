using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Abstract
{
    public interface IProductService
    {
        public Task<ServiceResponse<ProductDto>> GetProductList(int userId);
        public Task<ServiceResponse<ProductDto>> GetProductByProductId(int userId, int id);
        public Task<ServiceResponse<ProductDto>> SaveProduct(int userId, ProductDto modelDto);
        public Task<ServiceResponse<ProductDto>> SearchProducts();
        public Task<ServiceResponse<ProductDto>> DeleteProductById(int userId, int id);
    }
}
