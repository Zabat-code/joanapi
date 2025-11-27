namespace JOANAPI.Domain.Entities
{
    /// <summary>
    /// Represents a base implementation of the IBaseEntity interface.
    /// </summary>
    public abstract class BaseEntity  
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public Guid Id { get; set; } 

        /// <summary>
        /// Gets or sets the date and time when the entity was created.
        /// </summary>
        public DateTime Created { get; set; } 

        /// <summary>
        /// Gets or sets the date and time when the entity was last updated.
        /// </summary>
        public DateTime? Updated { get; set; }
 

        /// <summary>
        /// Gets or sets a value indicating whether the entity is deleted.
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// Updates the entity with the values from the source entity.
        /// </summary>
        /// <param name="source">The source entity</param>
        public abstract void UpdateValueFrom(BaseEntity source);

        /// <summary>
        /// Creates a shallow copy of the current entity.
        /// </summary>
        /// <returns>A shallow copy of the current entity.</returns>
        public T ShallowCopy<T>()
        {
            return (T)this.MemberwiseClone();
        }
    }
}