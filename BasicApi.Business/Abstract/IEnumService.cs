using BasicApi.Data.DtoModels;

namespace BasicApi.Business.Abstract
{
    public interface IEnumService
    {
        ServiceResponse<PaymenttypeDto> PaymenttypeList();
    }
}
