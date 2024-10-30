using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Interfaces
{
    public interface IAccountingSoftwareRepository
    {
        Task<AccountingSoftwareResponseModel> GetData();
    }
}
