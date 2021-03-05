using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryV2.Models.Entities
{
    public class Authors
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
