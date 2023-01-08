namespace WebApplication6.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }

        public int? CarID { get; set; }
        public Autovehicul? Autovehicul { get; set; }
    }
}
