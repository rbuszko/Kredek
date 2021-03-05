using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Models
{
    public class ContactFormViewModel
    {
        /// <summary>
        /// Imie
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ulica
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Miejscowość
        /// </summary>
        public string Locality { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Numer telefonu
        /// </summary>
        public string TelefonNumber { get; set; }
    }
}
