using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using Store.Domain.Interfaces;
using Store.Infrastructure.Data;

namespace Store.Infrastructure.Repositories
{
    public class UserRepository(AppDbContext dbContext) : IUserRepository
    {
        public async Task<UserEntity> AddUserAsync(UserEntity userEntity)
        {
            userEntity.Id = Guid.NewGuid();
            dbContext.Users.Add(userEntity);
            await dbContext.SaveChangesAsync();
            return userEntity;
        }

        public async Task<bool> DeleteUserAsync(Guid id)
        {
            var user = await GetUserById(id);
            if (user != null)
            {
                dbContext.Users.Remove(user);
                return await dbContext.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<UserEntity> GetUserById(Guid id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<UserEntity> UpdateUserAsync(UserEntity userEntity)
        {
            var user = await GetUserById(userEntity.Id);
            if (user != null)
            {
                user.Name = userEntity.Name;
                user.Email = userEntity.Email;
                user.Phone = userEntity.Phone;

                await dbContext.SaveChangesAsync();
                return user;
            }

            return userEntity;
        }
    }
}
