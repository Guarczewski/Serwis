using System.ComponentModel.DataAnnotations.Schema;

namespace Serwis.Models
{
    [Table("Interventions")]
    public class Intervention
    {
        public int InterventionID { get; set; }
        public string? WorkerID { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int IssueID { get; set; }
    }
}
