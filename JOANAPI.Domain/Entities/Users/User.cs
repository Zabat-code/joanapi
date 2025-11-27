namespace JOANAPI.Domain.Entities.Users
{
    /// <summary>
    /// Represents a system user entity within the domain layer.
    /// </summary>
    public class User :BaseEntity
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
        /// Gets or sets the hashed representation of the user's password.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the state of user, this is enable o disabled.
        /// </summary>
        public bool Status {  get; set; }
           public override void UpdateValueFrom(BaseEntity source)
        {
            if (source is User user)
            {
                Username = user.Username;
                Email = user.Email;
                PasswordHash = user.PasswordHash;
                Status = user.Status; 
            }
        }
    }
}