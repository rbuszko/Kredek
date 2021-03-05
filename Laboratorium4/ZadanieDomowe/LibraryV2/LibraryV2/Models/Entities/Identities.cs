using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace LibraryV2.Models.Entities
{
    public class Identities
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public byte[] Image { get; set; }
    }
}
