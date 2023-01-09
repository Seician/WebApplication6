using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace WebApplication6.Models
{
    public class Operatiune
    {

        public int ID { get; set; }
        public int? AngajatID { get; set; }
        public Angajat? Angajat { get; set; }
        public int? BookID { get; set; }
        public Client? Client { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
