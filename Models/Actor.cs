using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KR.Models
{
    public class Actor
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        public ICollection<Film>? Films { get; set; } = new List<Film>();
    }
}
