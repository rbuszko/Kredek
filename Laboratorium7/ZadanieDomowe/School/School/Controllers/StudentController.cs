using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using School.Controllers.Interfaces;
using School.Models;
using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// Zainicjalizowanie interfejsu ucznia przy pomocy bazy danych na ten moment
        /// </summary>
        private readonly IStudentRepository _studentRepository;
        /// <summary>
        /// Zainicjalizowanie mappera
        /// </summary>
        private readonly IMapper _mapper;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Zwraca wszystkich studentów
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult <IEnumerable<StudentViewModel>> GetAllStudents()
        {
            var students = _studentRepository.GetAllStudents();
            return Ok(_mapper.Map<IEnumerable<StudentViewModel>>(students));
        }
        /// <summary>
        /// Zwraca jednego studenta po Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetStudentById")]
        public ActionResult <StudentViewModel> GetStudentById(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            if (student != null)
            {
                return Ok(_mapper.Map<StudentViewModel>(student));
            }
            return NotFound();
        }
        
        /// <summary>
        /// Dodanie studenta do bazy danych
        /// </summary>
        /// <param name="studentCreateViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult <StudentViewModel> CreateStudent(StudentCreateUpdateViewModel studentCreateViewModel)
        {
            // Dodanie do bazy
            var studentMake = _mapper.Map<Student>(studentCreateViewModel);
            _studentRepository.CreateStudent(studentMake);
            _studentRepository.SaveChanges();

            // Poprawne pokazanie edytowanego dokumentu z id
            var studentRead = _mapper.Map<StudentViewModel>(studentMake);
            // Zwracamy ścieżkę do stworzonego ucznia
            return CreatedAtRoute(nameof(GetStudentById), new { Id = studentRead.Id }, studentRead);
        }
        /// <summary>
        /// Funkcja służy do zmiany parametrów studenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="studentUpdateViewModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, StudentCreateUpdateViewModel studentUpdateViewModel)
        {
            // Wyszukanie po id
            var studentFromRepositorium = _studentRepository.GetStudentById(id);
            // Jak nie ma to not found
            if (studentFromRepositorium == null)
            {
                return NotFound();
            }

            _mapper.Map(studentUpdateViewModel, studentFromRepositorium);
            // Wywołanie funkcji update student
            _studentRepository.UpdateStudent(studentFromRepositorium);
            // Zapisanie zmian w bazie
            _studentRepository.SaveChanges();
            return NoContent();
        }
        /// <summary>
        /// Funkcja usuwa ucznia z bazy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            // Wyszukanie po id
            var studentFromRepositorium = _studentRepository.GetStudentById(id);
            // Jak nie ma to not found
            if (studentFromRepositorium == null)
            {
                return NotFound();
            }
            // Wywołanie funkcji usunięcia studenta
            _studentRepository.DeleteStudent(studentFromRepositorium);
            // Zapisanie zmian w bazie
            _studentRepository.SaveChanges();
            return NoContent();
        }
    }
}
