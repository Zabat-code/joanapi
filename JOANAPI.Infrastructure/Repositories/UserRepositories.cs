

using JOANAPI.Application.Interfaces.Users;
using JOANAPI.Domain.Entities.Users;

namespace JOANAPI.Infrastructure.Repositories
{
    public class UserRepository  : IUserRepository
    {  
        Task<IEnumerable<User>> IUserRepository.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<User?> IUserRepository.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}