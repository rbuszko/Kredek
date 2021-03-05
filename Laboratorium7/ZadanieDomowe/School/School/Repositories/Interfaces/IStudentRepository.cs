using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers.Interfaces
{
    public interface IStudentRepository
    {
        /// <summary>
        /// Lista wszystkich uczniów
        /// </summary>
        IEnumerable<Student> GetAllStudents();
        /// <summary>
        /// Wyszukiwanie uczniów po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetStudentById(int id);
        /// <summary>
        /// Funkcja tworząca studenta
        /// </summary>
        /// <param name="student"></param>
        void CreateStudent(Student student);
        /// <summary>
        /// Zapisanie zmian
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
        /// <summary>
        /// Edycja studenta
        /// </summary>
        /// <param name="student"></param>
        void UpdateStudent(Student student);
        /// <summary>
        /// Usuwa studenta z bazy danych
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        void DeleteStudent(Student student);
    }
}
