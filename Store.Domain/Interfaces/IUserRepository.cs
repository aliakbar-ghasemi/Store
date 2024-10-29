using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetUsers();
        Task<UserEntity> GetUserById(Guid id);
        Task<UserEntity> AddUserAsync(UserEntity userEntity);
        Task<UserEntity> UpdateUserAsync(UserEntity userEntity);
        Task<bool> DeleteUserAsync(Guid id);
    }
}
