using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class StudentCreateUpdateViewModel
    {
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
    }
}
