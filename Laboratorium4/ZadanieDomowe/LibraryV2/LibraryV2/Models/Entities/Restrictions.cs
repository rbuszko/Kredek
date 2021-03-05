using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryV2.Models.Entities
{
    public class Restrictions
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string AgeLimit { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
