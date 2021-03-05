using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class TeacherCreateUpdateViewModel
    {
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
    }
}
