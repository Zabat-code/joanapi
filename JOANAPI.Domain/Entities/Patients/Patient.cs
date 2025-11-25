using JOANAPI.Enums;

namespace JOANAPI.Domain.Entities.Patients
{
    //<summary>
    // Represents a patient in the healthcare system.
    //</summary>
    public class Patient
    {
        //<summary>
        // Unique identifier for the patient.
        //</summary>
        public Guid Id { get; set; }

        //<summary>
        // First name of the patient.
        //</summary>
        public string FirstName { get; set; }  

        //<summary>
        // Last name of the patient.
        //</summary>
        public string LastName { get; set; }

        //<summary>
        // Date of birth of the patient.
        //</summary>
        public DateTime DateOfBirth { get; set; }

        //<summary>
        // Email address of the patient.
        //</summary>
        public string email { get; set; }

        //<summary>
        // Phone number of the patient. 
        //</summary>
        public string PhoneNumber { get; set; }

        //<summary>
        // Address of the patient.  
        //</summary>
        public string Address { get; set; }

        //<summary>
        // Gender of the patient.
        //</summary>
        public Gender Gender { get; set; }

        public string EmergencyContact { get; set; }
        public string IdentificationNumber { get; set; }
    }
}