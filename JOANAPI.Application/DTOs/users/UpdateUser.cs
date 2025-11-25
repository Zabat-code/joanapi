namespace JOANAPI.Application.DTOs.Users
{
    /// <summary>
    /// Data Transfer Object (DTO) for transferring user data between application layers.
    /// </summary>
    public class UpdateUserDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the user.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the username used for login and identification.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email address associated with the user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the password for the user.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the state of user, this is enable o disabled.
        /// </summary>
        public bool status { get; set; }
    }
}