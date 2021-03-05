using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryV2.Models.Entities
{
    public class States
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string Rental { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
