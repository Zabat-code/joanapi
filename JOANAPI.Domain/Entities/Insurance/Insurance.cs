namespace JOANAPI.Domain.Entities.Insurance
{
    /// <summary>
    /// Represents an insurance entity within the domain layer.
    /// </summary>
    public class Insurance : BaseEntity
    {  
        /// <summary>
        /// Gets or sets the name of the insurance provider.
        /// </summary>
        public string ProviderName { get; set; } 

        /// <summary>
        /// Gets or sets the coverage details of the insurance.
        /// </summary>
        public string CoverageDetails { get; set; }

        /// <summary>
        /// Gets or sets the policy number associated with the insurance.
        /// </summary>
        public IEnumerable<Patient> patients { get; set; }

        public override void UpdateValueFrom(BaseEntity source)
        {
            if (source is Insurance insurance)
            {
                ProviderName = insurance.ProviderName;
                PolicyNumber = insurance.PolicyNumber;
                CoverageDetails = insurance.CoverageDetails;
            }
        }
    }
}