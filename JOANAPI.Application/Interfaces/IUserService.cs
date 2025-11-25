using JOANAPI.Application.DTOs.Users;
using JOANAPI.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JOANAPI.Application.Interfaces
{

    /// <summary>
    /// Defines the contract for user-related operations within the application layer.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the user.</param>
        /// <returns>The user entity if found; otherwise, null.</returns>
        Task<UserDto> GetUserByIdAsync(Guid id);

        /// <summary>
        /// Retrieves all users in the system.
        /// </summary>
        /// <returns>A collection of all user entities.</returns>
        Task<IEnumerable<UserDto>> GetAllUsersAsync();

        /// <summary>
        /// Creates a new user in the system.
        /// </summary>
        /// <param name="user">The user entity to create.</param>
        /// <returns>The created user entity.</returns>
        Task<CreateUserDto> CreateUserAsync(User user);

        /// <summary>
        /// Updates an existing user in the system.
        /// </summary>
        /// <param name="user">The user entity with updated information.</param>
        /// <returns>The updated user entity.</returns>
        Task<UpdateUserDto> UpdateUserAsync(User user);

        /// <summary>
        /// Deletes a user by their unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the user to delete.</param>
        /// <returns>A boolean indicating whether the deletion was successful.</returns>
        Task<bool> DeleteUserAsync(Guid id);
    }
}