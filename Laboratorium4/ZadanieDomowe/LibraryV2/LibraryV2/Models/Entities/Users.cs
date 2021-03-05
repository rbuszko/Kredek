using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryV2.Models.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(64)]
        public string Login { get; set; }
        [Required]
        [MaxLength(64)]
        public string Password { get; set; }

        [Required]
        public int IdentitiesId { get; set; }
        [ForeignKey("IdentitiesId")]
        public virtual Identities Identities { get; set; }

        [Required]
        public int RolesId { get; set; }
        [ForeignKey("RolesId")]
        public virtual Roles Roles { get; set; }
    }
}
