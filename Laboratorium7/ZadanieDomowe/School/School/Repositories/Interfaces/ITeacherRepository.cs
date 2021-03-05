using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers.Interfaces
{
    public interface ITeacherRepository
    {
        /// <summary>
        /// Lista wszystkich nauczycieli
        /// </summary>
        IEnumerable<Teacher> GetAllTeachers();
        /// <summary>
        /// Wyszukiwanie nauczycieli po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Teacher GetTeacherById(int id);
        /// <summary>
        /// Funkcja tworząca nauczyciela
        /// </summary>
        /// <param name="student"></param>
        void CreateTeacher(Teacher teacher);
        /// <summary>
        /// Zapisanie zmian
        /// </summary>
        /// <returns></returns>
        bool SaveChanges();
        /// <summary>
        /// Edytowanie nauczyciela
        /// </summary>
        /// <param name="teacher"></param>
        void UpdateTeacher(Teacher teacher);
        /// <summary>
        /// Usuwa nauczyciela z bazy
        /// </summary>
        /// <param name="teacher"></param>
        void DeleteTeacher(Teacher teacher);
    }
}
