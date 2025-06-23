namespace Veterinaria.Models
{
    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Animal Animal { get; set; }
        public Veterinario Veterinario { get; set; }
        public List<Procedimento> Procedimentos { get; set; } = new List<Procedimento>();
    }
}
