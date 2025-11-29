using JOANAPI.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOANAPI.Application.Interfaces.Users
{
    /// <summary>
    /// Interface for user repository operations.
    /// </summary>
    public  interface IUserRepository
    {
        /// <summary>
        /// Retrieves all users asynchronously.
        /// </summary>
        Task<IEnumerable<User>> GetAllAsync();
        
        /// <summary>
        /// Retrieves a user by their unique identifier asynchronously.
        /// </summary>
        Task<User?> GetByIdAsync(Guid id);

        /// <summary>
        /// Adds a new user asynchronously.
        /// </summary>
        Task AddAsync(User user);

        /// <summary>
        /// Updates an existing user asynchronously.
        /// </summary>
        Task UpdateAsync(User user);

        /// <summary>
        /// Deletes a user asynchronously.
        /// </summary>
        Task DeleteAsync(User user);

        /// <summary>
        /// Saves changes to the data source asynchronously.
        /// </summary>
        Task SaveChangesAsync();
    }
}
