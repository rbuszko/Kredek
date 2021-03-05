using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.ViewModels
{
    public class StudentViewModel
    {
        /// <summary>
        /// Id ucznia
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Imię ucznia
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko ucznia
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Imię nauczyciela
        /// </summary>
        public int TeachersId { get; set; }
    }
}
