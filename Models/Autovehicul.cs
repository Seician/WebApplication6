namespace WebApplication6.Models
{
    public class Autovehicul
    {
        public int Id { get; set; }

        public string   Marca { get; set; }
        public int   An { get; set; }
        public string   Model { get; set; }
        public string   Problema { get; set; }

        public ICollection<Client> Clienti { get; set; }   
    }
}
