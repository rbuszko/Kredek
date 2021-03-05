using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryV2.Models.Entities
{
    public class Genres
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
