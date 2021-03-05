using School.Controllers.Interfaces;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Repositories
{
    /// <summary>
    /// Główne repozytorium szkoły połączone z bazą danych
    /// </summary>
    public class SqlSchoolRepository : IStudentRepository, ITeacherRepository
    {
        /// <summary>
        /// Obiekt naszej bazy
        /// </summary>
        private readonly DataBaseContext _dataBaseContext;

        public SqlSchoolRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        /// <summary>
        /// Funkcja dodaje studenta do bazy
        /// </summary>
        /// <param name="student"></param>
        public void CreateStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            _dataBaseContext.students.Add(student);
        }
        /// <summary>
        /// Funkcja dodaje nauczyciela do bazy
        /// </summary>
        /// <param name="teacher"></param>
        public void CreateTeacher(Teacher teacher)
        {
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }

            _dataBaseContext.teachers.Add(teacher);
        }
        /// <summary>
        /// Usuwa studenta z bazy
        /// </summary>
        /// <param name="student"></param>
        public void DeleteStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _dataBaseContext.students.Remove(student);
        }
        /// <summary>
        /// Usuwa nauczyciela z bazy
        /// </summary>
        /// <param name="teacher"></param>
        public void DeleteTeacher(Teacher teacher)
        {
            if (teacher == null)
            {
                throw new ArgumentNullException(nameof(teacher));
            }
            _dataBaseContext.teachers.Remove(teacher);
        }

        /// <summary>
        /// Funkcja zwraca wszystkich uczniów
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return _dataBaseContext.students.ToList();
        }
        /// <summary>
        /// Funkcja zwraca wszystkich nauczycieli
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Teacher> GetAllTeachers()
        {
            return _dataBaseContext.teachers.ToList();
        }
        /// <summary>
        /// Funkcja zwraca studentów po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetStudentById(int id)
        {
            return _dataBaseContext.students.FirstOrDefault(s => s.Id == id);
        }
        /// <summary>
        /// Funkcja zwraca nauczycieli po id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Teacher GetTeacherById(int id)
        {
            return _dataBaseContext.teachers.FirstOrDefault(t => t.Id == id);
        }
        /// <summary>
        /// Funkcja zapisuje dane w bazie
        /// </summary>
        /// <returns></returns>
        public bool SaveChanges()
        {
            return (_dataBaseContext.SaveChanges() >= 0);
        }
        /// <summary>
        /// Edytowanie studenta
        /// </summary>
        /// <param name="student"></param>
        public void UpdateStudent(Student student)
        {
            // Nie robimy nic
        }
        /// <summary>
        /// Edytowanie nauczyciela
        /// </summary>
        /// <param name="teacher"></param>
        public void UpdateTeacher(Teacher teacher)
        {
            // Nie robimy nic
        }
    }
}
