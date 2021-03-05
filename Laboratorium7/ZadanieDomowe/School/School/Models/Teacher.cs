using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Teacher
    {
        /// <summary>
        /// Id nauczyciela
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Imię nauczyciela
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko nauczyciela
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Przedmiot, którego uczy nauczyciel
        /// </summary>
        [Required]
        public string Course { get; set; }
        /// <summary>
        /// Uwzględnienie relacji jeden nauczyciel, wielu uczniów
        /// </summary>
        public virtual ICollection<Student> Students { get; set; }
    }
}
