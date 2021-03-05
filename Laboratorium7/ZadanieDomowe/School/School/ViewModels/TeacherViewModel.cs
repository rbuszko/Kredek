using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class TeacherViewModel
    {
        /// <summary>
        /// Id nauczyciela
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Imię nauczyciela
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko nauczyciela
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Przedmiot, którego uczy nauczyciel
        /// </summary>
        public string Course { get; set; }
    }
}
