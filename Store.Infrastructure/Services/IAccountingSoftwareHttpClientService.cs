using Store.Domain.Models;

namespace Store.Infrastructure.Services
{
    public interface IAccountingSoftwareHttpClientService
    {
        Task<AccountingSoftwareResponseModel> GetData();
    }
}