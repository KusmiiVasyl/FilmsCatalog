using System.ComponentModel.DataAnnotations.Schema;

namespace KR.Models
{
    public class FilmCategory
    {
        [ForeignKey("film")]
        [Column("film_id")]
        public int FilmId { get; set; }


        [ForeignKey("category")]
        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}