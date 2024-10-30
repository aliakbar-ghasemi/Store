using Store.Domain.Models;
using System.Net.Http.Json;

namespace Store.Infrastructure.Services
{
    public class AccountingSoftwareHttpClientService(HttpClient httpClient) : IAccountingSoftwareHttpClientService
    {
        public async Task<AccountingSoftwareResponseModel> GetData()
        {
            return await httpClient.GetFromJsonAsync<AccountingSoftwareResponseModel>("bpi/currentprice.json");
        }
    }
}
