using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryV2.Models.Entities
{
    public class Books
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(64)]
        public string PersonName { get; set; }
        [Required]
        [MaxLength(64)]
        public string Title { get; set; }

        [Required]
        public int AuthorsId { get; set; }
        [ForeignKey("AuthorsId")]
        public virtual Authors Authors { get; set; }

        [Required]
        public int GenresId { get; set; }
        [ForeignKey("GenresId")]
        public virtual Genres Genres { get; set; }

        [Required]
        public int StatesId { get; set; }
        [ForeignKey("StatesId")]
        public virtual States States { get; set; }

        [Required]
        public int RestrictionsId { get; set; }
        [ForeignKey("RestrictionsId")]
        public virtual Restrictions Restrictions { get; set; }
    }
}
