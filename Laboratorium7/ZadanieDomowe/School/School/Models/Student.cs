using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class Student
    {
        /// <summary>
        /// Id ucznia
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Imię ucznia
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko ucznia
        /// </summary>
        [Required]
        public string LastName { get; set; }
        /// <summary>
        /// Id nauczyciela
        /// </summary>
        [Required]
        public int TeachersId { get; set; }
        /// <summary>
        /// Klucz obcy, nie mam pojęcia czemu mi go nie wyłapuje
        /// </summary>
        [ForeignKey("TeachersId")]
        public virtual Teacher Teachers { get; set; }
    }
}
