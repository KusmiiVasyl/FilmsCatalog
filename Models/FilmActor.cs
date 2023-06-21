using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KR.Models
{
    public class FilmActor
    {
        [ForeignKey("actor")]
        [Column("actor_id")]
        public int ActorId { get; set; }


        [ForeignKey("film")]
        [Column("film_id")]
        public int FilmId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        public Actor Actor { get; set; }
        public Film Film { get; set; }
    }
}
