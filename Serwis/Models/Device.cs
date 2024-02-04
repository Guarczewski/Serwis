using System.ComponentModel.DataAnnotations.Schema;

namespace Serwis.Models
{
    [Table("Devices")]
    public class Device
    {
        public int DeviceID { get; set; }
        public String? Name { get; set; }
        public String? SerialNumber { get; set; }
        public String? Description { get; set; }
        public String? Adress { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
    }
}
