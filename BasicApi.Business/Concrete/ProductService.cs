using System;
using System.Threading.Tasks;
using BasicApi.Business.Abstract;
using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Concrete
{
    public class ProductService : IProductService
    {
        public Task<ServiceResponse<ProductDto>> DeleteProductById(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProductDto>> GetProductByProductId(int userId, int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProductDto>> GetProductList(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProductDto>> SaveProduct(int userId, ProductDto modelDto)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<ProductDto>> SearchProducts()
        {
            throw new NotImplementedException();
        }
    }
}
