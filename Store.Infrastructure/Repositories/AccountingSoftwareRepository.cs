using Store.Domain.Interfaces;
using Store.Domain.Models;
using Store.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repositories
{
    public class AccountingSoftwareRepository(AccountingSoftwareHttpClientService accountingSoftwareHttpClientService) : IAccountingSoftwareRepository
    {
        public async Task<AccountingSoftwareResponseModel> GetData()
        {
            return await accountingSoftwareHttpClientService.GetData();
        }
    }
}
