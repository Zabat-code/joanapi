using JOANAPI.Domain.Entities.Patients;

namespace JOANAPI.Domain.Entities.HistoryPatients
{
    public class HistoryPatient
    {
        public Guid Id { get; set; } 
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
 
        public Patient Patient { get; set; }
    }
}